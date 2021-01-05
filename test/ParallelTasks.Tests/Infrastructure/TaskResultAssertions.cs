using FluentAssertions;
using System;

namespace ParallelTasks.Tests
{
    public static class TaskResultAssertions
    {
        public static void ShouldBeCompleted(this ITaskResult taskResult)
        {
            taskResult.IsCompleted.Should().BeTrue();
            taskResult.IsCanceled.Should().BeFalse();
            taskResult.IsFaulted.Should().BeFalse();
            taskResult.Exception.Should().BeNull();
        }

        public static void ShouldBeCanceled(this ITaskResult taskResult)
        {
            taskResult.IsCompleted.Should().BeFalse();
            taskResult.IsCanceled.Should().BeTrue();
            taskResult.IsFaulted.Should().BeFalse();
            if (taskResult.Exception != null)
                taskResult.Exception.Should().BeAssignableTo<OperationCanceledException>();
        }

        public static void ShouldBeFaulted(this ITaskResult taskResult)
        {
            taskResult.IsCompleted.Should().BeFalse();
            taskResult.IsCanceled.Should().BeFalse();
            taskResult.IsFaulted.Should().BeTrue();
            taskResult.Exception.Should().NotBeOfType<OperationCanceledException>();
            taskResult.Exception.Should().NotBeNull();
        }

        public static void ShouldBeFaulted<T>(this ITaskResult taskResult)
            where T : Exception
        {
            taskResult.IsCompleted.Should().BeFalse();
            taskResult.IsCanceled.Should().BeFalse();
            taskResult.IsFaulted.Should().BeTrue();
            taskResult.Exception.Should().BeOfType<T>();
        }

        public static void ShouldMatch(this ITaskResult taskResult, string name, int? index)
        {
            taskResult.Name.Should().Be(name);
            taskResult.Index.Should().Be(index);
        }

        public static void ShouldBeVoid(this ITaskResult taskResult)
        {
            taskResult.IsVoid.Should().BeTrue();
            taskResult.Value.Should().Be(null);
        }

        public static void ShouldHaveResult(this ITaskResult taskResult, object result)
        {
            taskResult.IsVoid.Should().BeFalse();
            taskResult.Value.Should().Be(result);
        }

        public static void ShouldHaveResult<T>(this ITaskResult<T> taskResult, T result)
        {
            taskResult.IsVoid.Should().BeFalse();
            taskResult.Value.Should().Be(result);
        }

        public static void ShouldHaveSource<TSource>(this ISourcedTaskResult<TSource> taskResult, TSource source)
        {
            taskResult.Source.Should().Be(source);
        }

        public static void ShouldHaveSource<TSource, TResult>(this ISourcedTaskResult<TSource, TResult> taskResult, TSource source)
        {
            taskResult.Source.Should().Be(source);
        }
    }
}
