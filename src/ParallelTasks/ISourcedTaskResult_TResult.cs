namespace ParallelTasks
{
    /// <summary>
    /// Represents the result of a completed Task.Threading.Tasks.Task<typeparamref name="TResult"/> instance
    /// which is associated with a <typeparamref name="TSource"/> value.
    /// <typeparam name="TResult">The type of the Task's result.</typeparam>
    /// <typeparam name="TSource">The type of the source value the Task is associated with.</typeparam>
    /// </summary>
    public interface ISourcedTaskResult<TSource, TResult> : ISourcedTaskResult<TSource>, ITaskResult<TResult>
    {

    }
}

