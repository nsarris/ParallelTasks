using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using System.Threading;
using System;
using System.Linq;

namespace ParallelTasks.Tests
{
    public class TaskResult_Tests
    {
        [Fact]
        public async Task Should_Complete_Succesfully()
        {
            With.Value(
                await TestClass.TestMethod(
                    result: 1,
                    throwException: false,
                    cancellationToken: default,
                    simulateTask: true)
                .AsTaskResult("test", 2)
            )
            .Assert(x =>
            {
                x.ShouldMatch("test", 2);
                x.ShouldHaveResult(1);
                x.ShouldBeCompleted();
            });
        }

        [Fact]
        public async Task Should_Complete_As_Faulted()
        {

            With.Value(
                await TestClass.TestMethod(
                    result: 1,
                    throwException: true,
                    cancellationToken: default,
                    simulateTask: true)
                .AsTaskResult()
            )
            .Assert(x =>
            {
                x.ShouldMatch(null, null);
                x.ShouldHaveResult(default);
                x.ShouldBeFaulted<AwaitableException>();
            });
        }

        [Fact]
        public async Task Should_Complete_As_Cancelled()
        {
            var ct = new CancellationToken(true);

            With.Value(
                await TestClass.TestMethod(
                    result: 1,
                    throwException: true,
                    cancellationToken: ct,
                    simulateTask: true)
                .AsTaskResult()
            )
            .Assert(x =>
            {
                x.ShouldMatch(null, null);
                x.ShouldHaveResult(default);
                x.ShouldBeCanceled();
            });
        }

        [Fact]
        public async Task Should_Return_Result_From_Untyped_Task()
        {
            var taskOfInt = TestClass.TestMethod(
                result: 3,
                throwException: false,
                cancellationToken: default,
                simulateTask: true);

            var t = (Task)taskOfInt;

            await t;
            
            var taskResult = TaskResult.FromTask(t, "test", 1);

            taskResult.Value.Should().Be(3);
            taskResult.Name.Should().Be("test");
            taskResult.Index.Should().Be(1);

            var taskResultint = (ITaskResult<int>)taskResult;

            taskResultint.Value.Should().Be(3);
            taskResultint.Name.Should().Be("test");
            taskResultint.Index.Should().Be(1);
        }
    }
}
