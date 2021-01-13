using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks.Tests
{
    public class AwaitableException : Exception { }

    static class TestClass
    {
        public static async Task<T> TestMethod<T>(T result, bool throwException = false, CancellationToken cancellationToken = default, bool simulateTask = true)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (throwException)
                throw new AwaitableException();

            if (simulateTask)
                await Task.Delay(100);

            return result;
        }

        public static async Task TestVoidMethod(bool throwException = false, CancellationToken cancellationToken = default, bool simulateTask = true)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (throwException)
                throw new AwaitableException();

            if (simulateTask)
                await Task.Delay(100);

        }
    }
}
