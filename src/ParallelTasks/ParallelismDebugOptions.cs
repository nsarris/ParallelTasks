using System;

namespace ParallelTasks
{
    /// <summary>
    /// Options to assist debugging.
    /// </summary>
    public static class ParallelismDebugOptions
    {
        /// <summary>
        /// Function that returns whether the application is running in debug mode. Defaults to System.Diagnostics.Debugger.IsAttached.
        /// Replace with user function to change behaviour.
        /// </summary>
        public static Func<bool> GetIsDebugging { get; set; } = () => System.Diagnostics.Debugger.IsAttached;

        /// <summary>
        /// The maximum degree of parallelism in enumerable sourced parallel operations. Set to 0 to disable. Default is 0.
        /// </summary>
        public static int MaxDegreeOfParallelism { get; set; } = 0;


        internal static int AdjustDegreeOfParallelism(int degreeOfParallelism)
            => (GetIsDebugging?.Invoke() ?? false) && MaxDegreeOfParallelism > 0 && degreeOfParallelism > MaxDegreeOfParallelism ? MaxDegreeOfParallelism : degreeOfParallelism;
    }
}
