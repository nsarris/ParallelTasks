using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class SourcedTasks_WhenAll_Tests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected(bool simulateTask)
        {
            var source = new[] { 1, 3, 5 };

            static string operation(int value) => (value + 1).ToString();

            //Get a collection of TaskResults
            var results = await source.WhenAllAsync(x => TestClass.TestMethod(operation(x), simulateTask: simulateTask));

            foreach(var r in source.Zip(results, (sourceValue, result) => new { sourceValue, result }).Select((x,i) => new { x.sourceValue, x.result, index = i }))
            {
                r.result.ShouldBeCompleted();
                r.result.ShouldHaveResult(operation(r.sourceValue));
                r.result.ShouldMatch(null, 0);
                r.result.ShouldHaveSource(r.sourceValue);
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected_Named_Tasks(bool simulateTask)
        {
            var source = new (string name, int value)[] { ("name1", 1), ("name2", 3), ("name3", 5) };

            static string operation(int value) => (value + 1).ToString();

            //Get a collection of TaskResults
            var results = await source.WhenAllAsync(x => TestClass.TestMethod(operation(x), simulateTask: simulateTask));
            
            foreach (var r in source.Zip(results, (sourceValue, result) => new { sourceValue, result }).Select((x, i) => new { x.sourceValue, x.result, index = i }))
            {
                r.result.ShouldBeCompleted();
                r.result.ShouldHaveResult(operation(r.sourceValue.value));
                r.result.ShouldMatch(r.sourceValue.name, 0);
                r.result.ShouldHaveSource(r.sourceValue.value);
            }
        }
    }
}
