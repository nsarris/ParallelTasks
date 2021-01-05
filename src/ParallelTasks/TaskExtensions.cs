using System;
using System.Threading.Tasks;

namespace ParallelTasks
{
    public static class TaskExtensions
    {
        #region Tasks

        /// <summary>
        /// Transforms a Task to a Task<TaskResult>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsTaskResult(this Task task)
           => task.ContinueWith((x) => TaskResult.FromTask(x));

        /// <summary>
        /// Transforms a Task to a Task<TaskResult>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsTaskResult(this Task task, string name)
           => task.ContinueWith((x, state) => TaskResult.FromTask(x, (string)state), name);

        /// <summary>
        /// Transforms a Task to a Task<TaskResult>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsTaskResult(this Task task, int index)
           => task.ContinueWith((x, state) => TaskResult.FromTask(x, null, (int)state), index);

        /// <summary>
        /// Transforms a Task to a Task<TaskResult>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsTaskResult(this Task task, string name, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_name, _index) = (ValueTuple<string, int>)state;
                return TaskResult.FromTask(x, _name, _index);
            }, (name, index));

        internal static Task<ITaskResult> AsTaskResult(this Task task, string name, int? index)
            => index.HasValue ? AsTaskResult(task, name, index.Value) : AsTaskResult(task, name);

        #endregion

        #region Task<T>

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T>>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TResult>> AsTaskResult<TResult>(this Task<TResult> task)
            => task.ContinueWith((x) => TaskResult.FromTask(x));

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T>>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TResult>> AsTaskResult<TResult>(this Task<TResult> task, string name)
            => task.ContinueWith((x, state) => TaskResult.FromTask(x, (string)state), name);

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T>>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TResult>> AsTaskResult<TResult>(this Task<TResult> task, int index)
            => task.ContinueWith((x, state) => TaskResult.FromTask(x, null, (int)state), index);

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T>>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TResult>> AsTaskResult<TResult>(this Task<TResult> task, string name, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_name, _index) = (ValueTuple<string, int>)state;
                return TaskResult.FromTask(x, _name, _index);
            }, (name, index));

        internal static Task<ITaskResult<TResult>> AsTaskResult<TResult>(this Task<TResult> task, string name, int? index)
            => index.HasValue ? AsTaskResult(task, name, index.Value) : AsTaskResult(task, name);

        #endregion

        #region Task w/Source

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource>> AsTaskResult<TSource>(this Task task, TSource source)
            => task.ContinueWith((x, state) => TaskResult.FromTask((TSource)state, x), source);

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource>> AsTaskResult<TSource>(this Task task, TSource source, string name)
            => task.ContinueWith((x, state) =>
            {
                var (_source, _name) = (ValueTuple<TSource, string>)state;
                return TaskResult.FromTask(_source, x, _name);
            }, (source, name));

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource>> AsTaskResult<TSource>(this Task task, TSource source, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_source, _index) = (ValueTuple<TSource, int>)state;
                return TaskResult.FromTask(_source, x, null, _index);
            }, (source, index));

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource>> AsTaskResult<TSource>(this Task task, TSource source, string name, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_source, _name, _index) = (ValueTuple<TSource, string, int>)state;
                return TaskResult.FromTask(_source, x, _name, _index);
            }, (source, name, index));

        internal static Task<ISourcedTaskResult<TSource>> AsTaskResult<TSource>(this Task task, TSource source, string name, int? index)
           => index.HasValue ? AsTaskResult(task, source, name, index.Value) : AsTaskResult(task, source, name);

        #endregion

        #region Task<T> w/Source

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource, TResult>> AsTaskResult<TSource, TResult>(this Task<TResult> task, TSource source)
            => task.ContinueWith((x, state) => TaskResult.FromTask((TSource)state, x), source);

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource, TResult>> AsTaskResult<TSource, TResult>(this Task<TResult> task, TSource source, string name)
            => task.ContinueWith((x, state) =>
            {
                var (_source, _name) = (ValueTuple<TSource, string>)state;
                return TaskResult.FromTask(_source, x, _name);
            }, (source, name));

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource, TResult>> AsTaskResult<TSource, TResult>(this Task<TResult> task, TSource source, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_source, _index) = (ValueTuple<TSource, int>)state;
                return TaskResult.FromTask(_source, x, null, _index);
            }, (source, index));

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="source">The source value to associate the transformed task with.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ISourcedTaskResult<TSource, TResult>> AsTaskResult<TSource, TResult>(this Task<TResult> task, TSource source, string name, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_source, _name, _index) = (ValueTuple<TSource, string, int>)state;
                return TaskResult.FromTask(_source, x, _name, _index);
            }, (source, name, index));

        internal static Task<ISourcedTaskResult<TSource, TResult>> AsTaskResult<TSource, TResult>(this Task<TResult> task, TSource source, string name, int? index)
           => index.HasValue ? AsTaskResult(task, source, name, index.Value) : AsTaskResult(task, source, name);

        #endregion

        #region Task<T> w/transformation

        /// <summary>
        /// Transforms a Task<TSource> to a Task<TaskResult<TTransform>.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="transform">The function that transforms TSource to TTransform.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TTransform>> AsTaskResult<TResult, TTransform>(this Task<TResult> task, Func<TResult, TTransform> transform)
            => task.ContinueWith((x) => Transform(x, transform));

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="transform">The function that transforms TSource to TTransform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TTransform>> AsTaskResult<TResult, TTransform>(this Task<TResult> task, Func<TResult, TTransform> transform, string name)
            => task.ContinueWith((x, state) => Transform(x, transform, (string)state), name);

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="transform">The function that transforms TSource to TTransform.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TTransform>> AsTaskResult<TResult, TTransform>(this Task<TResult> task, Func<TResult, TTransform> transform, int index)
            => task.ContinueWith((x, state) => Transform(x, transform, null, (int)state), index);

        /// <summary>
        /// Transforms a Task<T> to a Task<TaskResult<T> and associates it with a source value.>
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="transform">The function that transforms TSource to TTransform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult<TTransform>> AsTaskResult<TResult, TTransform>(this Task<TResult> task, Func<TResult, TTransform> transform, string name, int index)
            => task.ContinueWith((x, state) => Transform(x, transform, (ValueTuple<string, int>)state), (name, index));

        private static ITaskResult<TResult> Transform<TSource, TResult>(Task<TSource> task, Func<TSource, TResult> transform, string name = null, int? index = null)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                try
                {
                    return TaskResult.FromResult(transform(task.Result), name, index);
                }
                catch (Exception e)
                {
                    return TaskResult.FromException<TResult>(e, name, index);
                }
            }
            else if (task.Status == TaskStatus.Canceled)
                return TaskResult.FromCancellation<TResult>(name, index);
            else
                return TaskResult.FromException<TResult>(task.Exception, name, index);
        }

        private static ITaskResult<TResult> Transform<TSource, TResult>(Task<TSource> task, Func<TSource, TResult> transform, (string name, int index) metadata)
            => Transform(task, transform, metadata.name, metadata.index);

        #endregion

        #region Task<T> to untyped TaskResult

        /// <summary>
        /// Transforms a Task<typeparamref name="TResult"/> to an untyped Task<TaskResult>.
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsUntypedTaskResult<TResult>(this Task<TResult> task)
            => task.ContinueWith((x) => (ITaskResult)TaskResult.FromTask(x));

        /// <summary>
        /// Transforms a Task<typeparamref name="TResult"/> to an untyped Task<TaskResult>.
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsUntypedTaskResult<TResult>(this Task<TResult> task, string name)
            => task.ContinueWith((x, state) => (ITaskResult)TaskResult.FromTask(x, (string)state), name);

        /// <summary>
        /// Transforms a Task<typeparamref name="TResult"/> to an untyped Task<TaskResult>.
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsUntypedTaskResult<TResult>(this Task<TResult> task, int index)
            => task.ContinueWith((x, state) => (ITaskResult)TaskResult.FromTask(x, null, (int)state), index);

        /// <summary>
        /// Transforms a Task<typeparamref name="TResult"/> to an untyped Task<TaskResult>.
        /// </summary>
        /// <param name="task">The task to transform.</param>
        /// <param name="name">The name to tag the task to transform with.</param>
        /// <param name="index">The index to tag the task to transform with.</param>
        /// <returns>A Task with TaskResult return type.</returns>
        public static Task<ITaskResult> AsUntypedTaskResult<TResult>(this Task<TResult> task, string name, int index)
            => task.ContinueWith((x, state) =>
            {
                var (_name, _index) = (ValueTuple<string, int>)state;
                return (ITaskResult)TaskResult.FromTask(x, _name, _index);
            }, (name, index));

        #endregion
    }
}

