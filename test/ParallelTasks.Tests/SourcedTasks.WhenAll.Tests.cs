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
        [InlineData(0, 0)]
        [InlineData(100, 0)]
        [InlineData(100, -1)]
        [InlineData(100, 3)]
        [InlineData(1000, 10)]
        public async Task Should_As_Many_Results_As_Source_Items(int itemCount, int degreeOfParallelism)
        {
            var result = await Enumerable.Range(0, itemCount)
                .WhenAllAsync(x => TestClass.TestMethod(x, simulateTask: false), degreeOfParallelism);

            result.Count().Should().Be(itemCount);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected(bool simulateTask)
        {
            var source = new[] { 1, 3, 5 };

            static string operation(int value) => (value + 1).ToString();

            //Get a collection of TaskResults
            var results = await source.WhenAllAsync(x => TestClass.TestMethod(operation(x), simulateTask: simulateTask));

            foreach (var r in source.Zip(results, (sourceValue, result) => new { sourceValue, result }).Select((x, i) => new { x.sourceValue, x.result, index = i }))
            {
                r.result.ShouldBeCompleted();
                r.result.ShouldHaveResult(operation(r.sourceValue));
                r.result.ShouldMatch(null, r.index);
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
                r.result.ShouldMatch(r.sourceValue.name, r.index);
                r.result.ShouldHaveSource(r.sourceValue.value);
            }
        }

        [Fact]
        public async Task Should_Complete_As_Cancelled()
        {
            var tokenSource = new System.Threading.CancellationTokenSource();
            var token = tokenSource.Token;

            tokenSource.Cancel();

            var total = 1000;

            var result = await Enumerable.Range(0, total)
                .WhenAllAsync((ct, x) => Task.Delay(500), token, 1);

            Assert.Equal(result.GetCanceled().Count(), total);
        }
    }
}
