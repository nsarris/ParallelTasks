using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace ParallelTasks
{
    public static partial class Tasks
    {
        #region WhenAll Implementation

        internal static async Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<NamedTaskFactory> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
        {
            var result = new List<ITaskResult>();

            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            if (tasks.Count == degreeOfParallelism)
                return await Task.WhenAll(tasks).AsEnumerable().ConfigureAwait(false);

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                result.Add(t.Result);
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }

            return result;
        }

        internal static async Task<IEnumerable<ITaskResult<TResult>>> WhenAll<TResult>(this IEnumerable<NamedTaskFactory<TResult>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
        {
            var result = new List<ITaskResult<TResult>>();

            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            if (tasks.Count == degreeOfParallelism)
                return await Task.WhenAll(tasks).AsEnumerable().ConfigureAwait(false);

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                result.Add(t.Result);
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }

            return result;
        }

        internal static async Task<IEnumerable<ISourcedTaskResult<TSource>>> WhenAll<TSource>(this IEnumerable<NamedSourcedTaskFactory<TSource>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
        {
            var result = new List<ISourcedTaskResult<TSource>>();

            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            if (tasks.Count == degreeOfParallelism)
                return await Task.WhenAll(tasks).AsEnumerable().ConfigureAwait(false);

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                result.Add(t.Result);
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }

            return result;
        }

        internal static async Task<IEnumerable<ISourcedTaskResult<TSource, TResult>>> WhenAll<TSource, TResult>(this IEnumerable<NamedSourcedTaskFactory<TSource, TResult>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
        {
            var result = new List<ISourcedTaskResult<TSource, TResult>>();

            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            if (tasks.Count == degreeOfParallelism)
                return await Task.WhenAll(tasks).AsEnumerable().ConfigureAwait(false);

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                result.Add(t.Result);
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }

            return result;
        }

        #endregion

        #region WhenEach Implementation

#if NETSTANDARD2_PLUS

        internal static async IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<NamedTaskFactory> taskFactories, [EnumeratorCancellation] CancellationToken cancellationToken, int degreeOfParallelism)
        {
            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            if (degreeOfParallelism <= 0)
                degreeOfParallelism = taskFactories.Count();

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                yield return t.Result;
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }
        }

        internal static async IAsyncEnumerable<ITaskResult<TResult>> WhenEach<TResult>(this IEnumerable<NamedTaskFactory<TResult>> taskFactories, [EnumeratorCancellation] CancellationToken cancellationToken, int degreeOfParallelism)
        {
            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            if (degreeOfParallelism <= 0)
                degreeOfParallelism = taskFactories.Count();

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                yield return t.Result;
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }
        }

        internal static async IAsyncEnumerable<ISourcedTaskResult<TSource>> WhenEach<TSource>(this IEnumerable<NamedSourcedTaskFactory<TSource>> taskFactories, [EnumeratorCancellation] CancellationToken cancellationToken, int degreeOfParallelism)
        {
            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            if (degreeOfParallelism <= 0)
                degreeOfParallelism = taskFactories.Count();

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                yield return t.Result;
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }
        }

        internal static async IAsyncEnumerable<ISourcedTaskResult<TSource, TResult>> WhenEach<TSource, TResult>(this IEnumerable<NamedSourcedTaskFactory<TSource, TResult>> taskFactories, [EnumeratorCancellation] CancellationToken cancellationToken, int degreeOfParallelism)
        {
            degreeOfParallelism = ParallelismDebugOptions.AdjustDegreeOfParallelism(degreeOfParallelism);

            if (degreeOfParallelism <= 0)
                degreeOfParallelism = taskFactories.Count();

            var tasks = taskFactories
                .Take(degreeOfParallelism)
                .Select(t => t.GetTask(cancellationToken))
                .ToList();

            var queue = taskFactories
                .Skip(degreeOfParallelism)
                .ToQueue();

            while (tasks.Any())
            {
                var t = await Task.WhenAny(tasks);
                yield return t.Result;
                tasks.Remove(t);
                if (queue.Any())
                {
                    var nextItem = queue.Dequeue();
                    tasks.Add(nextItem.GetTask(cancellationToken));
                }
            }
        }
#endif
        #endregion

        #region WhenAny Implementation

        internal static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<NamedTaskFactory<T>> tasks, CancellationToken cancellationToken)
            => Task.WhenAny(tasks.Select(x => x.GetTask(cancellationToken))).Unwrap();

        internal static Task<ITaskResult> WhenAny(this IEnumerable<NamedTaskFactory> tasks, CancellationToken cancellationToken)
            => Task.WhenAny(tasks.Select(x => x.GetTask(cancellationToken))).Unwrap();

        internal static Task<ISourcedTaskResult<TSource>> WhenAny<TSource>(this IEnumerable<NamedSourcedTaskFactory<TSource>> tasks, CancellationToken cancellationToken)
            => Task.WhenAny(tasks.Select(x => x.GetTask(cancellationToken))).Unwrap();

        internal static Task<ISourcedTaskResult<TSource, TResult>> WhenAny<TSource, TResult>(this IEnumerable<NamedSourcedTaskFactory<TSource, TResult>> tasks, CancellationToken cancellationToken)
            => Task.WhenAny(tasks.Select(x => x.GetTask(cancellationToken))).Unwrap();

        #endregion

        #region WhenAll Enumerable of Tasks 

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<Task> tasks)
            => Task.WhenAll(tasks.AsTaskResults()).AsEnumerable();

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<(string name, Task task)> tasks)
            => Task.WhenAll(tasks.AsTaskResults()).AsEnumerable();

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<Func<Task>> tasks)
            => tasks.ToNamedFactories().WhenAll(CancellationToken.None, 0);

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<Func<CancellationToken, Task>> taskFactories, CancellationToken cancellationToken)
            => taskFactories.ToNamedFactories().WhenAll(cancellationToken, 0);

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<Func<Task>> taskFactories, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenAll(CancellationToken.None, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<Func<CancellationToken, Task>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenAll(cancellationToken, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<(string name, Func<Task> createTask)> namedTaskFactories, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenAll(CancellationToken.None, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult>> WhenAll(this IEnumerable<(string name, Func<CancellationToken, Task>)> namedTaskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenAll(cancellationToken, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<Task<T>> tasks)
            => Task.WhenAll(tasks.AsTaskResults()).AsEnumerable();

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<(string name, Task<T> task)> tasks)
            => Task.WhenAll(tasks.AsTaskResults()).AsEnumerable();

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<Func<Task<T>>> tasks)
            => tasks.ToNamedFactories().WhenAll(CancellationToken.None, 0);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<Func<CancellationToken, Task<T>>> taskFactories, CancellationToken cancellationToken)
            => taskFactories.ToNamedFactories().WhenAll(cancellationToken, 0);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<Func<Task<T>>> taskFactories, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenAll(CancellationToken.None, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<Func<CancellationToken, Task<T>>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenAll(cancellationToken, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<(string name, Func<Task<T>> createTask)> namedTaskFactories, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenAll(CancellationToken.None, degreeOfParallelism);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(this IEnumerable<(string name, Func<CancellationToken, Task<T>> createTask)> namedTaskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenAll(cancellationToken, degreeOfParallelism);

        #endregion

        #region WhenAll Array of Tasks

        public static Task<IEnumerable<ITaskResult>> WhenAll(params Task[] tasks)
            => WhenAll(tasks.AsEnumerable());

        public static Task<IEnumerable<ITaskResult>> WhenAll(params (string name, Task task)[] tasks)
            => WhenAll(tasks.AsEnumerable());

        public static Task<IEnumerable<ITaskResult>> WhenAll(params Func<Task>[] tasks)
            => WhenAll(tasks.AsEnumerable());

        public static Task<IEnumerable<ITaskResult>> WhenAll(params (string name, Func<Task> value)[] tasks)
            => WhenAll(tasks.AsEnumerable(), 0);

        public static Task<IEnumerable<ITaskResult>> WhenAll(CancellationToken cancellationToken, params Func<CancellationToken, Task>[] tasks)
            => WhenAll(tasks.AsEnumerable(), cancellationToken);

        public static Task<IEnumerable<ITaskResult>> WhenAll(CancellationToken cancellationToken, params (string name, Func<CancellationToken, Task> value)[] tasks)
            => WhenAll(tasks.AsEnumerable(), cancellationToken, 0);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(params Task<T>[] tasks)
            => WhenAll(tasks.AsEnumerable());

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(params (string name, Task<T> task)[] tasks)
            => WhenAll(tasks.AsEnumerable());

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(params Func<Task<T>>[] tasks)
            => WhenAll(tasks.AsEnumerable());

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(params (string name, Func<Task<T>> value)[] tasks)
            => WhenAll(tasks.AsEnumerable(), 0);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(CancellationToken cancellationToken, params Func<CancellationToken, Task<T>>[] tasks)
            => WhenAll(tasks.AsEnumerable(), cancellationToken);

        public static Task<IEnumerable<ITaskResult<T>>> WhenAll<T>(CancellationToken cancellationToken, params (string name, Func<CancellationToken, Task<T>> value)[] tasks)
            => WhenAll(tasks.AsEnumerable(), cancellationToken, 0);

        #endregion

        #region WhenEach Enumerable of Tasks 

#if NETSTANDARD2_PLUS
        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<Task> tasks)
            => tasks.ToNamedFactories().WhenEach(CancellationToken.None, 0);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<(string name, Task task)> tasks)
            => tasks.ToNamedFactories().WhenEach(CancellationToken.None, 0);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<Func<Task>> tasks)
            => tasks.ToNamedFactories().WhenEach(CancellationToken.None, 0);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<Func<CancellationToken, Task>> taskFactories, CancellationToken cancellationToken)
            => taskFactories.ToNamedFactories().WhenEach(cancellationToken, 0);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<Func<Task>> taskFactories, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenEach(CancellationToken.None, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<Func<CancellationToken, Task>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenEach(cancellationToken, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<(string name, Func<Task> createTask)> namedTaskFactories, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenEach(CancellationToken.None, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult> WhenEach(this IEnumerable<(string name, Func<CancellationToken, Task>)> namedTaskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenEach(cancellationToken, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<Task<T>> tasks)
            => tasks.ToNamedFactories().WhenEach(CancellationToken.None, 0);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<(string name, Task<T> task)> tasks)
            => tasks.ToNamedFactories().WhenEach(CancellationToken.None, 0);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<Func<Task<T>>> tasks)
            => tasks.ToNamedFactories().WhenEach(CancellationToken.None, 0);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<Func<CancellationToken, Task<T>>> taskFactories, CancellationToken cancellationToken)
            => taskFactories.ToNamedFactories().WhenEach(cancellationToken, 0);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<Func<Task<T>>> taskFactories, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenEach(CancellationToken.None, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<Func<CancellationToken, Task<T>>> taskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => taskFactories.ToNamedFactories().WhenEach(cancellationToken, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<(string name, Func<Task<T>> createTask)> namedTaskFactories, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenEach(CancellationToken.None, degreeOfParallelism);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(this IEnumerable<(string name, Func<CancellationToken, Task<T>> createTask)> namedTaskFactories, CancellationToken cancellationToken, int degreeOfParallelism)
            => namedTaskFactories.ToNamedFactories().WhenEach(cancellationToken, degreeOfParallelism);
#endif
        #endregion

        #region WhenEach Array of Tasks

#if NETSTANDARD2_PLUS
        public static IAsyncEnumerable<ITaskResult> WhenEach(params Task[] tasks)
            => WhenEach(tasks.AsEnumerable());

        public static IAsyncEnumerable<ITaskResult> WhenEach(params (string name, Task task)[] tasks)
            => WhenEach(tasks.AsEnumerable());

        public static IAsyncEnumerable<ITaskResult> WhenEach(params Func<Task>[] tasks)
            => WhenEach(tasks.AsEnumerable());

        public static IAsyncEnumerable<ITaskResult> WhenEach(params (string name, Func<Task> createTask)[] tasks)
            => WhenEach(tasks.AsEnumerable(), 0);

        public static IAsyncEnumerable<ITaskResult> WhenEach(CancellationToken cancellationToken, params Func<CancellationToken, Task>[] tasks)
            => WhenEach(tasks.AsEnumerable(), cancellationToken);

        public static IAsyncEnumerable<ITaskResult> WhenEach(CancellationToken cancellationToken, params (string name, Func<CancellationToken, Task> createTask)[] tasks)
            => WhenEach(tasks.AsEnumerable(), cancellationToken, 0);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(params Task<T>[] tasks)
            => WhenEach(tasks.AsEnumerable());

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(params (string name, Task<T> task)[] tasks)
            => WhenEach(tasks.AsEnumerable());

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(params Func<Task<T>>[] tasks)
            => WhenEach(tasks.AsEnumerable());

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(params (string name, Func<Task<T>> createTask)[] tasks)
            => WhenEach(tasks.AsEnumerable(), 0);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(CancellationToken cancellationToken, params Func<CancellationToken, Task<T>>[] tasks)
            => WhenEach(tasks.AsEnumerable(), cancellationToken);

        public static IAsyncEnumerable<ITaskResult<T>> WhenEach<T>(CancellationToken cancellationToken, params (string name, Func<CancellationToken, Task<T>> createTask)[] tasks)
            => WhenEach(tasks.AsEnumerable(), cancellationToken, 0);
#endif
        #endregion

        #region WhenAny Enumerable of Tasks 

        public static Task<ITaskResult> WhenAny(this IEnumerable<Task> tasks)
            => Task.WhenAny(tasks.AsTaskResults()).Unwrap();

        public static Task<ITaskResult> WhenAny(this IEnumerable<(string name, Task task)> tasks)
            => Task.WhenAny(tasks.AsTaskResults()).Unwrap();

        public static Task<ITaskResult> WhenAny(this IEnumerable<Func<Task>> tasks)
            => tasks.ToNamedFactories().WhenAny(CancellationToken.None);

        public static Task<ITaskResult> WhenAny(this IEnumerable<(string name, Func<Task> createTask)> tasks)
            => tasks.ToNamedFactories().WhenAny(CancellationToken.None);

        public static Task<ITaskResult> WhenAny(this IEnumerable<Func<CancellationToken, Task>> tasks, CancellationToken cancellationToken)
            => tasks.ToNamedFactories().WhenAny(cancellationToken);

        public static Task<ITaskResult> WhenAny(this IEnumerable<(string name, Func<CancellationToken, Task> createTask)> tasks, CancellationToken cancellationToken)
            => tasks.ToNamedFactories().WhenAny(cancellationToken);

        public static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<Task<T>> tasks)
            => Task.WhenAny(tasks.AsTaskResults()).Unwrap();

        public static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<(string name, Task<T> task)> tasks)
            => Task.WhenAny(tasks.AsTaskResults()).Unwrap();

        public static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<(string name, Func<Task<T>> createTask)> tasks)
            => tasks.ToNamedFactories().WhenAny(CancellationToken.None);

        public static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<Func<Task<T>>> tasks)
            => tasks.ToNamedFactories().WhenAny(CancellationToken.None);

        public static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<Func<CancellationToken, Task<T>>> tasks, CancellationToken cancellationToken)
            => tasks.ToNamedFactories().WhenAny(cancellationToken);

        public static Task<ITaskResult<T>> WhenAny<T>(this IEnumerable<(string name, Func<CancellationToken, Task<T>> createTask)> tasks, CancellationToken cancellationToken)
            => tasks.ToNamedFactories().WhenAny(cancellationToken);

        #endregion

        #region WhenAny Array of Tasks

        public static Task<ITaskResult> WhenAny(params Task[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult> WhenAny(params (string name, Task task)[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult> WhenAny(params Func<Task>[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult> WhenAny(params (string name, Func<Task> createTask)[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult> WhenAny(CancellationToken cancellationToken, params Func<CancellationToken, Task>[] tasks)
            => WhenAny(tasks.AsEnumerable(), cancellationToken);

        public static Task<ITaskResult> WhenAny(CancellationToken cancellationToken, params (string name, Func<CancellationToken, Task> createTask)[] tasks)
            => WhenAny(tasks.AsEnumerable(), cancellationToken);

        public static Task<ITaskResult<T>> WhenAny<T>(params Task<T>[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult<T>> WhenAny<T>(params (string name, Task<T> task)[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult<T>> WhenAny<T>(params Func<Task<T>>[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult<T>> WhenAny<T>(params (string name, Func<Task<T>> createTask)[] tasks)
            => WhenAny(tasks.AsEnumerable());

        public static Task<ITaskResult<T>> WhenAny<T>(CancellationToken cancellationToken, params Func<CancellationToken, Task<T>>[] tasks)
            => WhenAny(tasks.AsEnumerable(), cancellationToken);

        public static Task<ITaskResult<T>> WhenAny<T>(CancellationToken cancellationToken, params (string name, Func<CancellationToken, Task<T>> createTask)[] tasks)
            => WhenAny(tasks.AsEnumerable(), cancellationToken);

        #endregion

        #region Private Helpers

        private static Queue<T> ToQueue<T>(this IEnumerable<T> source)
            => new Queue<T>(source);

        private static IEnumerable<NamedTaskFactory> ToNamedFactories(this IEnumerable<Task> tasks)
            => tasks.Select((x, i) => new NamedTaskFactory(x, i)).ToList();

        private static IEnumerable<NamedTaskFactory> ToNamedFactories(this IEnumerable<Func<Task>> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory(x, i)).ToList();

        private static IEnumerable<NamedTaskFactory> ToNamedFactories(this IEnumerable<(string name, Task task)> tasks)
            => tasks.Select((x, i) => new NamedTaskFactory(x.task, x.name, i)).ToList();

        private static IEnumerable<NamedTaskFactory> ToNamedFactories(this IEnumerable<(string name, Func<Task> createTask)> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory(x.createTask, x.name, i)).ToList();

        private static IEnumerable<NamedTaskFactory> ToNamedFactories(this IEnumerable<Func<CancellationToken, Task>> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory(x, i)).ToList();

        private static IEnumerable<NamedTaskFactory> ToNamedFactories(this IEnumerable<(string name, Func<CancellationToken, Task> createTask)> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory(x.createTask, x.name, i)).ToList();

        private static IEnumerable<NamedTaskFactory<T>> ToNamedFactories<T>(this IEnumerable<Task<T>> tasks)
            => tasks.Select((x, i) => new NamedTaskFactory<T>(x, i)).ToList();

        private static IEnumerable<NamedTaskFactory<T>> ToNamedFactories<T>(this IEnumerable<Func<Task<T>>> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory<T>(x, i)).ToList();

        private static IEnumerable<NamedTaskFactory<T>> ToNamedFactories<T>(this IEnumerable<(string name, Task<T> task)> tasks)
            => tasks.Select((x, i) => new NamedTaskFactory<T>(x.task, x.name, i)).ToList();

        private static IEnumerable<NamedTaskFactory<T>> ToNamedFactories<T>(this IEnumerable<(string name, Func<Task<T>> createTask)> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory<T>(x.createTask, x.name, i)).ToList();

        private static IEnumerable<NamedTaskFactory<T>> ToNamedFactories<T>(this IEnumerable<Func<CancellationToken, Task<T>>> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory<T>(x, i)).ToList();

        private static IEnumerable<NamedTaskFactory<T>> ToNamedFactories<T>(this IEnumerable<(string name, Func<CancellationToken, Task<T>> createTask)> taskFactories)
            => taskFactories.Select((x, i) => new NamedTaskFactory<T>(x.createTask, x.name, i)).ToList();

        private static Task<IEnumerable<T>> AsEnumerable<T>(this Task<T[]> tasks)
            where T : ITaskResult
            => tasks.ContinueWith(x => x.Result.AsEnumerable());

        private static IEnumerable<Task<ITaskResult>> AsTaskResults(this IEnumerable<Task> tasks)
            => tasks.Select((x, i) => x.AsTaskResult(i));

        private static IEnumerable<Task<ITaskResult>> AsTaskResults(this IEnumerable<(string name, Task task)> tasks)
            => tasks.Select((x, i) => x.task.AsTaskResult(x.name, i));

        private static IEnumerable<Task<ITaskResult<T>>> AsTaskResults<T>(this IEnumerable<Task<T>> tasks)
            => tasks.Select((x, i) => x.AsTaskResult(i));

        private static IEnumerable<Task<ITaskResult<T>>> AsTaskResults<T>(this IEnumerable<(string name, Task<T> task)> tasks)
            => tasks.Select((x, i) => x.task.AsTaskResult(x.name, i));

        #endregion

        #region Private Helpers for generated code

        private static Task AsTask<T>(this Task<T> task) => task;
        private static (string name, Task value) AsTask<T>(this (string name, Task<T> value) task) => (task.name, task.value);
        private static Func<Task> AsTask<T>(this Func<Task<T>> createTask) => () => createTask();
        private static (string name, Func<Task> value) AsTask<T>(this (string name, Func<Task<T>> create) taskFactory) => (taskFactory.name, () => taskFactory.create());
        private static Func<CancellationToken, Task> AsTask<T>(this Func<CancellationToken, Task<T>> createTask) => (ct) => createTask(ct);
        private static (string name, Func<CancellationToken, Task> value) AsTask<T>(this (string name, Func<CancellationToken, Task<T>> create) taskFactory) => (taskFactory.name, (ct) => taskFactory.create(ct));

        #endregion
    }
}
