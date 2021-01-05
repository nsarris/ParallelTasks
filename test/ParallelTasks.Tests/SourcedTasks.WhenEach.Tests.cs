using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class SourcedTasks_WhenEach_Tests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected(bool simulateTask)
        {
            var source = new[] { 1, 3, 5 };

            static string operation(int value) => (value + 1).ToString();

            //Asynchronously iterate results
            await foreach (var r in source.WhenEach(x => TestClass.TestMethod(operation(x), simulateTask: simulateTask)))
            {
                var sourceValue = source[r.Index.Value];

                r.ShouldBeCompleted();
                r.ShouldHaveResult(operation(sourceValue));
                r.ShouldMatch(null, r.Index.Value);
                r.ShouldHaveSource(sourceValue);
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected_Named_Tasks(bool simulateTask)
        {
            var source = new (string name, int value)[] { ("name1", 1), ("name2", 3), ("name3", 5) };

            static string operation(int value) => (value + 1).ToString();

            //Asynchronously iterate results
            await foreach (var r in source.WhenEach(x => TestClass.TestMethod(operation(x), simulateTask: simulateTask)))
            {
                var sourceValue = source[r.Index.Value].value;
                var sourceName = source[r.Index.Value].name;

                r.ShouldBeCompleted();
                r.ShouldHaveResult(operation(sourceValue));
                r.ShouldMatch(sourceName, r.Index.Value);
                r.ShouldHaveSource(sourceValue);
            }
        }
    }
}
