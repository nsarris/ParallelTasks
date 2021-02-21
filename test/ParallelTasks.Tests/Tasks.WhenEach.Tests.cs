using FluentAssertions;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class Tasks_WhenEach_Tests
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

            //Asynchronously iterate results
            await foreach (var result in Tasks.WhenEach(
               TestClass.TestMethod(intValue, simulateTask: simulateTask),
               TestClass.TestMethod(stringValue, simulateTask: simulateTask),
               TestClass.TestMethod(dateTimeValue, simulateTask: simulateTask),
               TestClass.TestMethod(boolValue, simulateTask: simulateTask)))
            {
                if (result.Index == 0)
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(intValue);
                }
                else if (result.Index == 1)
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(stringValue);
                }
                else if (result.Index == 2)
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(dateTimeValue);
                }
                else if (result.Index == 3)
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(boolValue);
                }
            }
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

            //Asynchronously iterate results
            await foreach (var result in Tasks.WhenEach(
               ("intTask", TestClass.TestMethod(intValue, simulateTask: simulateTask)),
               ("stringTask", TestClass.TestMethod(stringValue, simulateTask: simulateTask)),
               ("dateTask", TestClass.TestMethod(dateTimeValue, simulateTask: simulateTask)),
               ("boolTask", TestClass.TestMethod(boolValue, simulateTask: simulateTask))))
            {
                if (result.Name == "intTask")
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(intValue);
                    result.ShouldMatch("intTask", 0);
                }
                else if (result.Name == "stringTask")
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(stringValue);
                    result.ShouldMatch("stringTask", 1);
                }
                else if (result.Name == "dateTask")
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(dateTimeValue);
                    result.ShouldMatch("dateTask", 2);
                }
                else if (result.Name == "boolTask")
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(boolValue);
                    result.ShouldMatch("boolTask", 3);
                }
            }
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

            //Asynchronously iterate results
            await foreach (var result in Tasks.WhenEach(
               ("intTask", TestClass.TestMethod(intValue, simulateTask: simulateTask)),
               ("stringTask", TestClass.TestMethod(stringValue, throwException: true, simulateTask: simulateTask)),
               ("dateTask", TestClass.TestMethod(dateTimeValue, cancellationToken: new CancellationToken(true), simulateTask: simulateTask)),
               ("boolTask", TestClass.TestMethod(boolValue, simulateTask: simulateTask))))
            {
                if (result.Name == "intTask")
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(intValue);
                    result.ShouldMatch("intTask", 0);
                }
                else if (result.Name == "stringTask")
                {
                    result.ShouldBeFaulted<AwaitableException>();
                    result.ShouldMatch("stringTask", 1);
                }
                else if (result.Name == "dateTask")
                {
                    result.ShouldBeCanceled();
                    result.ShouldMatch("dateTask", 2);
                }
                else if (result.Name == "boolTask")
                {
                    result.ShouldBeCompleted();
                    result.ShouldHaveResult(boolValue);
                    result.ShouldMatch("boolTask", 3);
                }
            }
        }
    }
}
