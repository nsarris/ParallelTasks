using FluentAssertions;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class Tasks_WhenAll_Tests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected(bool simulateTask)
        {
            var intValue = 1;
            var stringValue = "A";
            var dateTimeValue = DateTime.Now;
            var boolValue = true;

            //Get a collection of TaskResults
            var result = await Tasks.WhenAll(
               TestClass.TestMethod(intValue, simulateTask: simulateTask),
               TestClass.TestMethod(stringValue, simulateTask: simulateTask),
               TestClass.TestMethod(dateTimeValue, simulateTask: simulateTask),
               TestClass.TestMethod(boolValue, simulateTask: simulateTask));

            //Check if all results are succesfull
            result.AllCompletedSuccessfully.Should().BeTrue();

            //Decompose as tuple if inner Result values
            var (intResultValue, stringResultValue, dateResultValue, boolResultValue) = result.AsTupleOfValues();

            intResultValue.Should().Be(intValue);
            stringResultValue.Should().Be(stringValue);
            dateResultValue.Should().Be(dateTimeValue);
            boolResultValue.Should().Be(boolValue);

            //Decompose as tuple of TaskResults
            var (intResult, stringResult, dateResult, boolResult) = result.AsTuple();

            With.Value(intResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(intValue);
                x.ShouldMatch(null, 0);
            });

            With.Value(stringResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(stringValue);
                x.ShouldMatch(null, 1);
            });

            With.Value(dateResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(dateTimeValue);
                x.ShouldMatch(null, 2);
            });

            With.Value(boolResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(boolValue);
                x.ShouldMatch(null, 3);
            });
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected_Named_Tasks(bool simulateTask)
        {
            var intValue = 1;
            var stringValue = "A";
            var dateTimeValue = DateTime.Now;
            var boolValue = true;

            //Get a collection of named TaskResults
            var result = await Tasks.WhenAll(
               ( "intTask", TestClass.TestMethod(intValue, simulateTask: simulateTask)),
               ( "stringTask", TestClass.TestMethod(stringValue, simulateTask: simulateTask)),
               ( "dateTask", TestClass.TestMethod(dateTimeValue, simulateTask: simulateTask)),
               ( "boolTask", TestClass.TestMethod(boolValue, simulateTask: simulateTask))
             );

            //Check if all results are succesfull
            result.AllCompletedSuccessfully.Should().BeTrue();

            //Decompose as tuple of inner Result values
            var (intResultValue, stringResultValue, dateResultValue, boolResultValue) = result.AsTupleOfValues();

            intResultValue.Should().Be(intValue);
            stringResultValue.Should().Be(stringValue);
            dateResultValue.Should().Be(dateTimeValue);
            boolResultValue.Should().Be(boolValue);

            //Decompose as tuple of TaskResults
            var (intResult, stringResult, dateResult, boolResult) = result.AsTuple();

            With.Value(intResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(intValue);
                x.ShouldMatch("intTask", 0);
            });

            With.Value(stringResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(stringValue);
                x.ShouldMatch("stringTask", 1);
            });

            With.Value(dateResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(dateTimeValue);
                x.ShouldMatch("dateTask", 2);
            });

            With.Value(boolResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(boolValue);
                x.ShouldMatch("boolTask", 3);
            });
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_With_Various_Results(bool simulateTask)
        {
            var intValue = 1;
            var stringValue = "A";
            var dateTimeValue = DateTime.Now;
            var boolValue = true;

            //Get a collection of named TaskResults
            var result = await Tasks.WhenAll(
               ("intTask", TestClass.TestMethod(intValue, simulateTask: simulateTask)),
               ("stringTask", TestClass.TestMethod(stringValue, throwException: true, simulateTask: simulateTask)),
               ("dateTask", TestClass.TestMethod(dateTimeValue, cancellationToken: new CancellationToken(true), simulateTask: simulateTask)),
               ("boolTask", TestClass.TestMethod(boolValue, simulateTask: simulateTask))
             );

            //Check if all results are succesfull
            result.AllCompletedSuccessfully.Should().BeFalse();

            //Decompose as tuple of TaskResults
            var (intResult, stringResult, dateResult, boolResult) = result.AsTuple();

            With.Value(intResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(intValue);
                x.ShouldMatch("intTask", 0);
            });

            With.Value(stringResult)
            .Assert(x =>
            {
                x.ShouldBeFaulted<AwaitableException>();
                x.ShouldMatch("stringTask", 1);
            });

            With.Value(dateResult)
            .Assert(x =>
            {
                x.ShouldBeCanceled();
                x.ShouldMatch("dateTask", 2);
            });

            With.Value(boolResult)
            .Assert(x =>
            {
                x.ShouldBeCompleted();
                x.ShouldHaveResult(boolValue);
                x.ShouldMatch("boolTask", 3);
            });
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_With_Various_Results_Using_Enumeration(bool simulateTask)
        {
            var intValue = 1;
            var stringValue = "A";
            var dateTimeValue = DateTime.Now;
            var boolValue = true;

            //Get a collection of named TaskResults
            var result = await Tasks.WhenAll(
               ("intTask", TestClass.TestMethod(intValue, simulateTask: simulateTask)),
               ("stringTask", TestClass.TestMethod(stringValue, throwException: true, simulateTask: simulateTask)),
               ("dateTask", TestClass.TestMethod(dateTimeValue, cancellationToken: new CancellationToken(true), simulateTask: simulateTask)),
               ("boolTask", TestClass.TestMethod(boolValue, simulateTask: simulateTask))
             );

            //Check if all results are succesfull
            result.AllCompletedSuccessfully.Should().BeFalse();

            var i = 0;
            foreach(var taskResult in result)
            {
                With.Value(taskResult)
                .Assert(x =>
                {
                    if (i == 0)
                    {
                        x.ShouldBeCompleted();
                        x.ShouldHaveResult(intValue);
                        x.ShouldMatch("intTask", 0);
                    }
                    else if (i == 1)
                    {
                        x.ShouldBeFaulted<AwaitableException>();
                        x.ShouldMatch("stringTask", 1);
                    }
                    else if (i == 2)
                    {
                        x.ShouldBeCanceled();
                        x.ShouldMatch("dateTask", 2);
                    }
                    else if (i == 3)
                    {
                        x.ShouldBeCompleted();
                        x.ShouldHaveResult(boolValue);
                        x.ShouldMatch("boolTask", 3);
                    }
                });
                i++;
            }
        }
    }
}
