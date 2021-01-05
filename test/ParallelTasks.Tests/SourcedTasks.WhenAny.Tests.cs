using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class SourcedTasks_WhenAny_Tests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected(bool simulateTask)
        {
            var source = new[] { 1, 3, 5 };

            //Get a random result
            var result = await source.WhenAny(x => TestClass.TestMethod(x, simulateTask: simulateTask));

            result.ShouldBeCompleted();
            result.ShouldHaveResult(result.Source);
            result.ShouldHaveSource(result.Value);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Should_Complete_As_Expected_Named_Tasks(bool simulateTask)
        {
            var source = new (string name, int value)[] { ("1", 1), ("3", 3), ("5", 5) };

            //Get a random result
            var result = await source.WhenAny((int x) => TestClass.TestMethod(x, simulateTask: simulateTask));

            result.ShouldBeCompleted();
            result.ShouldHaveResult(result.Source);
            result.ShouldHaveSource(result.Value);
            result.Name.Should().Be(result.Value.ToString());
        }
    }
}
