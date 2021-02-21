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
}

