using System;
using System.Collections.Generic;
using System.Linq;

namespace ParallelTasks
{
    public static class TaskResultExtensions
    {
        /// <summary>
        /// Check if all results in a collection are succesfully completed. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>True if all tasks completed succesfully, othrewise false</returns>
        public static bool AllCompletedSuccessfully(this IEnumerable<ITaskResult> taskResults)
            => !taskResults.Any(x => x.IsCanceled || x.IsFaulted);

        /// <summary>
        /// Check if all results in a collection have been canceled or failed. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>True if all tasks completed with error or canceled, othrewise false</returns>
        public static bool AllFailedOrCanceled(this IEnumerable<ITaskResult> taskResults)
            => !taskResults.Any(x => x.IsCompleted);

        /// <summary>
        /// Gets all the failed results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>An enumeration of failed results.</returns>
        public static IEnumerable<ITaskResult> GetFailed(this IEnumerable<ITaskResult> taskResults)
            => taskResults.Where(x => x.IsFaulted);

        /// <summary>
        /// Gets all the canceled results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>An enumeration of canceled results.</returns>
        public static IEnumerable<ITaskResult> GetCanceled(this IEnumerable<ITaskResult> taskResults)
            => taskResults.Where(x => x.IsCanceled);

        /// <summary>
        /// Gets all the failed or canceled results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>An enumeration of failed or canceled results.</returns>
        public static IEnumerable<ITaskResult> GetFailedOrCanceled(this IEnumerable<ITaskResult> taskResults)
            => taskResults.Where(x => x.IsFaulted || x.IsCanceled);

        /// <summary>
        /// Gets all the succesfull results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>An enumeration of failed or canceled results.</returns>
        public static IEnumerable<ITaskResult> GetSuccessfull(this IEnumerable<ITaskResult> taskResults)
            => taskResults.Where(x => x.IsCompleted);

        /// <summary>
        /// Gets all the exceptions from the failed results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>An enumeration of exceptions.</returns>
        public static IEnumerable<Exception> GetAllExceptions(this IEnumerable<ITaskResult> taskResults)
            => taskResults.Where(x => x.Exception != null).Select(x => x.Exception);

        /// <summary>
        /// Concat all the exception messages from the failed results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>A string of concated exception messages.</returns>
        public static string ConcatAllExceptionMessages(this IEnumerable<ITaskResult> taskResults, string seperator = ",")
            => string.Join(seperator, taskResults.GetAllExceptions().Select(x => x.Message));

        /// <summary>
        /// Concat all the exceptions from the failed results in an enumeration. 
        /// </summary>
        /// <param name="taskResults">The enumeration of ITaskResults.</param>
        /// <returns>A string of concated exception strings after calling ToString on each exception.</returns>
        public static string ConcatAllExceptionStrings(this IEnumerable<ITaskResult> taskResults, string seperator = ",")
            => string.Join(seperator, taskResults.GetAllExceptions().Select(x => x.ToString()));
    }
}

