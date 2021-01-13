using System;

namespace ParallelTasks
{
    /// <summary>
    /// Represents the result of a completed Task.Threading.Tasks.Task instance.
    /// </summary>
    public interface ITaskResult
    {
        /// <summary>
        /// Gets the name given to the originating task, or null if no name was provided.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the index of the originating task, if the task was provided in a collection;null otherwise.
        /// </summary>
        int? Index { get; }

        /// <summary>
        /// Gets the completion status of the originating task.
        /// </summary>
        TaskResultStatus Status { get; }

        /// <summary>
        /// Gets whether the originating task was not returning a result(void); otherwise false.
        /// </summary>
        bool IsVoid { get; }

        /// <summary>
        /// Gets the value returned as the result of the originating task, or null if no result was returned due to cancellation or fault.
        /// </summary>
        object Value { get; }

        /// <summary>
        /// Gets the exception that occured during execution of the originating task; null otherwise.
        /// </summary>
        Exception Exception { get; }

        /// <summary>
        /// Gets whether the originating task instance has completed execution due to being canceled.
        /// </summary>
        bool IsCanceled { get; }

        /// <summary>
        /// Gets whether the originating task has completed succesfully.
        /// </summary>
        bool IsCompleted { get; }

        /// <summary>
        /// Gets whether the originating System.Threading.Tasks.Task completed due to an unhandled exception.
        /// </summary>
        bool IsFaulted { get; }
    }






    //public class SourcedTaskResult<TSource> : TaskResult, ISourcedTaskResult<TSource>
    //{
    //    internal SourcedTaskResult(TSource source, Exception exception, string tag = null, int? index = null)
    //        : base(exception, tag, index)
    //    {
    //        Source = source;
    //    }

    //    internal SourcedTaskResult(TSource source, Task task, string tag = null, int? index = null)
    //        : base(task, tag, index)
    //    {
    //        Source = source;
    //    }

    //    protected SourcedTaskResult(TSource source, object result, string tag = null, int? index = null)
    //        : base(result, tag, index)
    //    {
    //        Source = source;
    //    }

    //    protected SourcedTaskResult(TSource source, Task task, object result, string tag = null, int? index = null)
    //        : base(task, result, tag, index)
    //    {
    //        Source = source;
    //    }

    //    /// <summary>
    //    /// The source value associated with this TaskResult.
    //    /// </summary>
    //    public TSource Source { get; }
    //}

    ///// <summary>
    ///// Represents the result of a completed Task.Threading.Tasks.Task<typeparamref name="TResult"/> instance
    ///// which is associated with a <typeparamref name="TSource"/> value.
    ///// <typeparam name="TResult">The type of the Task's result.</typeparam>
    ///// <typeparam name="TSource">The type of the source value the Task is associated with.</typeparam>
    ///// </summary>
    //public class TaskResult<TSource, TResult> : SourcedTaskResult<TSource>, ISourcedTaskResult<TSource, TResult>
    //{
    //    internal TaskResult(TSource source, Exception exception, string tag = null, int? index = null)
    //        : base(source, exception, tag, index)
    //    {

    //    }

    //    internal TaskResult(TSource source, TResult result, string tag = null, int? index = null)
    //       : base(source, result, tag, index)
    //    {
    //        Value = base.Value is null ? default : (TResult)base.Value;
    //    }

    //    internal TaskResult(TSource source, Task<TResult> task, string tag = null, int? index = null)
    //        : base(source, task, task.Status == TaskStatus.RanToCompletion ? (object)task.Result : null, tag, index)
    //    {
    //        Value = base.Value is null ? default : (TResult)base.Value;
    //    }

    //    /// <summary>
    //    /// Gets the value returned as the result of the originating task, or null if no result was returned due to cancellation or fault.
    //    /// </summary>
    //    public new TResult Value { get; }
    //}
}

