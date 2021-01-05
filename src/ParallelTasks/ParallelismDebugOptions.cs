using System;

namespace ParallelTasks
{
    /// <summary>
    /// Options to assist debugging.
    /// </summary>
    public static class ParallelismDebugOptions
    {
        /// <summary>
        /// Function that returns wether the application is running in debug mode.
        /// </summary>
        public static Func<bool> GetIsDebugging { get; set; } = () => false;

        /// <summary>
        /// The maximum degree of parallelism in batch operations. Set to 0 to disable. Default is 0.
        /// </summary>
        public static int MaxBatchSize { get; set; } = 0;


        internal static int AdjustDegreeOfParallelism(int batchSize)
            => (GetIsDebugging?.Invoke() ?? false) && MaxBatchSize > 0 && batchSize > MaxBatchSize ? MaxBatchSize : batchSize;
    }
}
