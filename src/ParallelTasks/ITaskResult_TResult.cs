namespace ParallelTasks
{
    /// <summary>
    /// Represents the result of a completed Task.Threading.Tasks.Task<typeparamref name="TResult"/> instance.
    /// <typeparam name="TResult">The type of the Task's result.</typeparam>
    /// </summary>
    public interface ITaskResult<out TResult> : ITaskResult
    {
        /// <summary>
        /// Gets the value returned as the result of the originating task, or null if no result was returned due to cancellation or fault.
        /// </summary>
        new TResult Value { get; }
    }
}

