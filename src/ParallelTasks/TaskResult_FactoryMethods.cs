using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParallelTasks
{
    public static class TaskResult
    {
        public static ITaskResult<T> FromResult<T>(T result, string name = null, int? index = null)
            => new TaskResult<T>(result, name, index);

        public static ISourcedTaskResult<TSource, TResult> FromResult<TSource, TResult>(TSource source, TResult result, string name = null, int? index = null)
            => new TaskResult<TSource, TResult>(source, result, name, index);

        public static ITaskResult FromException(Exception exception, string name = null, int? index = null)
            => new VoidTaskResult(exception, name, index);

        public static ISourcedTaskResult<TSource, TResult> FromException<TSource, TResult>(TSource source, Exception exception, string name = null, int? index = null)
            => new TaskResult<TSource, TResult>(source, exception, name, index);

        public static ISourcedTaskResult<TSource> FromException<TSource>(TSource source, Exception exception, string name = null, int? index = null)
            => new VoidTaskResult<TSource>(source, exception, name, index);

        public static ITaskResult<T> FromException<T>(Exception exception, string name = null, int? index = null)
            => new TaskResult<T>(exception, name, index);

        public static ITaskResult FromCancellation(string name = null, int? index = null)
            => new VoidTaskResult(TaskResultStatus.Canceled, name, index);

        public static ITaskResult<T> FromCancellation<T>(string name = null, int? index = null)
            => new TaskResult<T>(TaskResultStatus.Canceled, name, index);

        public static ISourcedTaskResult<TSource, TResult> FromCancellation<TSource, TResult>(TSource source, string name = null, int? index = null)
            => new TaskResult<TSource, TResult>(source, TaskResultStatus.Canceled, name, index);

        public static ISourcedTaskResult<TSource> FromCancellation<TSource>(TSource source, string name = null, int? index = null)
            => new VoidTaskResult<TSource>(source, TaskResultStatus.Canceled, name, index);

        public static ITaskResult<T> FromTask<T>(Task<T> task, string name = null, int? index = null)
            => new TaskResult<T>(task, name, index);

        public static ISourcedTaskResult<TSource, TResult> FromTask<TSource, TResult>(TSource source, Task<TResult> task, string name = null, int? index = null)
            => new TaskResult<TSource, TResult>(source, task, name, index);

        public static ISourcedTaskResult<TSource> FromTask<TSource>(TSource source, Task task, string name = null, int? index = null)
              => task.IsTaskOfT(out var resultType) ?
                GetTypedFactory<TSource>(resultType)(source, task, name, index) :
                new VoidTaskResult<TSource>(source, task, name, index);

        public static ITaskResult FromTask(Task task, string name = null, int? index = null)
            => task.IsTaskOfT(out var resultType) ?
                GetTypedFactory(resultType)(task, name, index) :
                new VoidTaskResult(task, name, index);

        #region TypedTask Reflection Helpers 

        private delegate ITaskResult FromTypedTaskDelegate(Task task, string name, int? index);
        private delegate ISourcedTaskResult<TSource> FromTypedTaskDelegate<TSource>(TSource source, Task task, string name, int? index);

        private static readonly ConcurrentDictionary<Type, FromTypedTaskDelegate> typedFactories = new ConcurrentDictionary<Type, FromTypedTaskDelegate>();
        private static readonly ConcurrentDictionary<Type, Delegate> typedSourcedFactories = new ConcurrentDictionary<Type, Delegate>();

        private static FromTypedTaskDelegate GetTypedFactory(Type resultType)
        {
            if (!typedFactories.TryGetValue(resultType, out var factory))
            {
                factory = BuildFromTaskMethod(resultType);
                typedFactories[resultType] = factory;
            }

            return factory;
        }

        private static FromTypedTaskDelegate<TSource> GetTypedFactory<TSource>(Type resultType)
        {
            if (!typedSourcedFactories.TryGetValue(resultType, out var factory))
            {
                factory = BuildFromSourcedTaskMethod<TSource>(resultType);
                typedSourcedFactories[resultType] = factory;
            }

            return (FromTypedTaskDelegate<TSource>)factory;
        }

        private readonly static Lazy<System.Reflection.MethodInfo> fromTaskOfTMethod =
            new Lazy<System.Reflection.MethodInfo>(() =>
            ReflectionHelper
                .ExtractMethod(() => FromTask<object>(null, null, null))
                .GetGenericMethodDefinition());

        private readonly static Lazy<System.Reflection.MethodInfo> fromSourcedTaskOfTMethod =
            new Lazy<System.Reflection.MethodInfo>(() =>
            ReflectionHelper
                .ExtractMethod(() => FromTask<object, object>(null, null, null, null))
                .GetGenericMethodDefinition());

        private static FromTypedTaskDelegate BuildFromTaskMethod(Type resultType)
        {
            var methodInfo = fromTaskOfTMethod.Value.MakeGenericMethod(resultType);
            var taskType = typeof(Task<>).MakeGenericType(resultType);

            var taskParameter = Expression.Parameter(typeof(Task));
            var nameParameter = Expression.Parameter(typeof(string));
            var indexParameter = Expression.Parameter(typeof(int?));

            var body = Expression.Call(methodInfo,
                Expression.Convert(taskParameter, taskType),
                nameParameter,
                indexParameter);

            var lambda = Expression.Lambda<FromTypedTaskDelegate>(
                    Expression.Convert(body, typeof(ITaskResult)),
                    taskParameter, nameParameter, indexParameter);

            return lambda.Compile();
        }

        private static FromTypedTaskDelegate<TSource> BuildFromSourcedTaskMethod<TSource>(Type resultType)
        {
            var methodInfo = fromSourcedTaskOfTMethod.Value.MakeGenericMethod(typeof(TSource), resultType);
            var taskType = typeof(Task<>).MakeGenericType(resultType);

            var sourceParameter = Expression.Parameter(typeof(TSource));
            var taskParameter = Expression.Parameter(typeof(Task));
            var nameParameter = Expression.Parameter(typeof(string));
            var indexParameter = Expression.Parameter(typeof(int?));

            var body = Expression.Call(methodInfo,
                sourceParameter,
                Expression.Convert(taskParameter, taskType),
                nameParameter,
                indexParameter);

            var lambda = Expression.Lambda<FromTypedTaskDelegate<TSource>>(
                    Expression.Convert(body, typeof(ISourcedTaskResult<TSource>)),
                    sourceParameter, taskParameter, nameParameter, indexParameter);

            return lambda.Compile();
        }

        #endregion
    }
}
