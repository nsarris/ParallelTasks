namespace ParallelTasks
{
    /// <summary>
    /// Represents the status of a completed System.Threading.Tasks.Task.
    /// </summary>
    public enum TaskResultStatus
    {
        /// <summary>
        /// The task completed execution successfully.
        /// </summary>
        Completed,

        /// <summary>
        /// The task acknowledged cancellation by throwing an OperationCanceledException
        /// with its own CancellationToken while the token was in signaled state, or the
        /// task's CancellationToken was already signaled before the task started executing.
        /// For more information, see Task Cancellation.
        /// </summary>
        Canceled,

        /// <summary>
        /// The task completed due to an unhandled exception.
        /// </summary>
        Faulted
    }
}

