using FluentAssertions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class TaskResult_Factory_Tests
    {
        #region Infrastructure

        readonly string name = "name";
        readonly int? index = 2;
        readonly int source = 5;
        readonly string value = "r";

        private async Task<Task> GetVoidTask(bool canceled = false, bool throwException = false)
        {
            var t = TestClass.TestVoidMethod(
                throwException: throwException,
                cancellationToken: canceled ? new CancellationToken(true) : default,
                simulateTask: true);
            try
            {
                await t;
            }
            catch
            {
                //swallow
            }

            return t;
        }

        private async Task<Task<string>> GetTask(bool canceled = false, bool throwException = false)
        {
            var t = TestClass.TestMethod(
                result: value,
                throwException: throwException,
                cancellationToken: canceled ? new CancellationToken(true) : default,
                simulateTask: true);

            try
            {
                await t;
            }
            catch
            {
                //swallow
            }

            return t;
        }

        private async Task<Task> GetUntypedTask(bool canceled = false, bool throwException = false)
        {
            var t = GetTask(canceled, throwException).Unwrap();

            try
            {
                await t;
            }
            catch
            {
                //swallow
            }

            return t;
        }

        #endregion

        #region FromResult 

        [Fact]
        public void Should_Build_FromResult()
        {
            With.Value(
                TaskResult.FromResult(value, name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldHaveResult(value);
                x.ShouldBeCompleted();
            });
        }

        [Fact]
        public void Should_Build_FromResult_With_Source()
        {
            With.Value(
                TaskResult.FromResult(source, value, name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldHaveResult(value);
                x.ShouldBeCompleted();
                x.ShouldHaveSource(source);
            });
        }

        #endregion

        #region FromException
        
        [Fact]
        public void Should_Build_FromException()
        {
            With.Value(
                TaskResult.FromException(new AwaitableException(), name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
            });
        }

        [Fact]
        public void Should_Build_FromException_Typed()
        {
            With.Value(
                TaskResult.FromException<string>(new AwaitableException(), name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
            });
        }

        [Fact]
        public void Should_Build_FromException_With_Source()
        {
            With.Value(
                TaskResult.FromException(source, new AwaitableException(), name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public void Should_Build_FromException_Typed_With_Source()
        {
            With.Value(
                TaskResult.FromException<int, string>(source, new AwaitableException(), name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
                x.ShouldHaveSource(source);
            });
        }

        #endregion

        #region FromCancellation

        [Fact]
        public void Should_Build_FromCancellation()
        {
            With.Value(
                TaskResult.FromCancellation(name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
            });
        }

        [Fact]
        public void Should_Build_FromCancellation_Typed()
        {
            With.Value(
                TaskResult.FromCancellation<string>(name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
            });
        }

        [Fact]
        public void Should_Build_FromCancellation_With_Source()
        {
            With.Value(
                TaskResult.FromCancellation(source, name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public void Should_Build_FromCancellation_Typed_With_Source()
        {
            With.Value(
                TaskResult.FromCancellation<int, string>(source, name, index)
            )
            .Assert(x =>
            {
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
                x.ShouldHaveSource(source);
            });
        }

        #endregion

        #region FromTask with Completed Task

        [Fact]
        public async Task Should_Build_From_Task_With_Result()
        {
            With.Value(
                TaskResult.FromTask(await GetTask(), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult<string>>();
                x.ShouldMatch(name, index);
                x.ShouldHaveResult(value);
                x.ShouldBeCompleted();
            });
        }

        [Fact]
        public async Task Should_Build_From_Void_Task()
        {
            With.Value(
                TaskResult.FromTask(await GetVoidTask(), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult>();
                x.ShouldMatch(name, index);
                x.ShouldBeVoid();
                x.ShouldBeCompleted();
            });
        }

        [Fact]
        public async Task Should_Build_From_Untyped_Task_With_Result()
        {
            With.Value(
                TaskResult.FromTask(await GetUntypedTask(), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult<string>>();
                x.ShouldMatch(name, index);
                x.ShouldHaveResult(value);
                x.ShouldBeCompleted();
            });
        }

        [Fact]
        public async Task Should_Build_From_Task_With_Result_And_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetTask(), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int, string>>();
                x.ShouldMatch(name, index);
                x.ShouldHaveResult(value);
                x.ShouldBeCompleted();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public async Task Should_Build_From_Void_Task_With_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetVoidTask(), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int>>();
                x.ShouldMatch(name, index);
                x.ShouldBeVoid();
                x.ShouldBeCompleted();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public async Task Should_Build_From_Untyped_Task_With_Result_And_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetUntypedTask(), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int, string>>();
                x.ShouldMatch(name, index);
                x.ShouldHaveResult(value);
                x.ShouldBeCompleted();
                x.ShouldHaveSource(source);
            });
        }

        #endregion

        #region FromTask with Canceled Task

        [Fact]
        public async Task Should_Build_From_Canceled_Task_With_Result()
        {
            With.Value(
                TaskResult.FromTask(await GetTask(true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult<string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
            });
        }

        [Fact]
        public async Task Should_Build_From_Canceled_Void_Task()
        {
            With.Value(
                TaskResult.FromTask(await GetVoidTask(true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult>();
                x.ShouldMatch(name, index);
                x.ShouldBeVoid();
                x.ShouldBeCanceled();
            });
        }

        [Fact]
        public async Task Should_Build_From_Untyped_Canceled_Task_With_Result()
        {
            With.Value(
                TaskResult.FromTask(await GetUntypedTask(true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult<string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
            });
        }

        [Fact]
        public async Task Should_Build_From_Canceled_Task_With_Result_And_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetTask(true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int, string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public async Task Should_Build_From_Canceled_Void_Task_With_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetVoidTask(true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int>>();
                x.ShouldMatch(name, index);
                x.ShouldBeVoid();
                x.ShouldBeCanceled();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public async Task Should_Build_From_Untyped_Canceled_Task_With_Result_And_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetUntypedTask(true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int, string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeCanceled();
                x.ShouldHaveSource(source);
            });
        }

        #endregion

        #region FromTask with Faulted Task

        [Fact]
        public async Task Should_Build_From_Faulted_Task_With_Result()
        {
            With.Value(
                TaskResult.FromTask(await GetTask(throwException: true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult<string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
            });
        }

        [Fact]
        public async Task Should_Build_From_Faulted_Void_Task()
        {
            With.Value(
                TaskResult.FromTask(await GetVoidTask(throwException: true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult>();
                x.ShouldMatch(name, index);
                x.ShouldBeVoid();
                x.ShouldBeFaulted<AwaitableException>();
            });
        }

        [Fact]
        public async Task Should_Build_From_Untyped_Faulted_Task_With_Result()
        {
            With.Value(
                TaskResult.FromTask(await GetUntypedTask(throwException: true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ITaskResult<string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
            });
        }

        [Fact]
        public async Task Should_Build_From_Faulted_Task_With_Result_And_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetTask(throwException: true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int, string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public async Task Should_Build_From_Faulted_Void_Task_With_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetVoidTask(throwException: true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int>>();
                x.ShouldMatch(name, index);
                x.ShouldBeVoid();
                x.ShouldBeFaulted<AwaitableException>();
                x.ShouldHaveSource(source);
            });
        }

        [Fact]
        public async Task Should_Build_From_Untyped_Faulted_Task_With_Result_And_Source()
        {
            With.Value(
                TaskResult.FromTask(source, await GetUntypedTask(throwException: true), name, index)
            )
            .Assert(x =>
            {
                x.Should().BeAssignableTo<ISourcedTaskResult<int, string>>();
                x.ShouldMatch(name, index);
                x.ShouldBeFaulted<AwaitableException>();
                x.ShouldHaveSource(source);
            });
        }

        #endregion
    }
}
