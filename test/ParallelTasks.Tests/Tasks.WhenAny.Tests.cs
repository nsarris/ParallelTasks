using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ParallelTasks.Tests
{
    public class Tasks_WhenAny_Tests
    {
        [Fact]
        public async Task Should_Complete_As_Expected()
        {
            var intValue = 1;
            var stringValue = "A";
            var dateTimeValue = DateTime.Now;
            
            var t1 = Task.FromResult(intValue);
            var t2 = Task.Run(async () =>
            {
                await Task.Delay(1000);
                return dateTimeValue;
            });
            var t3 = Task.Run(async () =>
            {
                await Task.Delay(500);
                return stringValue;
            });


            var result = await Tasks.WhenAny(t1, t2, t3);
            result.Index.Should().Be(0);
            result.Value.Should().Be(intValue);
            
            result = await Tasks.WhenAny(t2, t3);
            result.Index.Should().Be(1);
            result.Value.Should().Be(stringValue);
        }

        [Fact]
        public async Task Should_Complete_As_Expected_Named()
        {
            var intValue = 1;
            var stringValue = "A";
            var dateTimeValue = DateTime.Now;

            var t1 = ("intTask", Task.FromResult(intValue));
            var t2 = ("dateTask", Task.Run(async () =>
            {
                await Task.Delay(1000);
                return dateTimeValue;
            }));
            var t3 = ("stringTask", Task.Run(async () =>
            {
                await Task.Delay(500);
                return stringValue;
            }));

            var result = await Tasks.WhenAny(t1, t2, t3);
                
            result.Index.Should().Be(0);
            result.Name.Should().Be("intTask");
            result.Value.Should().Be(intValue);

            result = await Tasks.WhenAny(t2, t3);
                
            result.Index.Should().Be(1);
            result.Name.Should().Be("stringTask");
            result.Value.Should().Be(stringValue);
        }
    }
}
