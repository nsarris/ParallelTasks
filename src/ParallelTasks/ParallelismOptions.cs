namespace ParallelTasks
{
    /// <summary>
    /// Ddefault parallelism options.
    /// </summary>
    public static class ParallelismOptions
    {
        /// <summary>
        /// The default degree of parallelism in enumerable sourced parallel operations. Set to 0 to disable. Default is 0.
        /// </summary>
        public static int DefaultDegreeOfParallelism { get; } = 0;
    }
}
