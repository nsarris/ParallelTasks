using System;

namespace ParallelTasks.Tests
{
    public static class With
    {
        public static With<T> Value<T>(T value) => new With<T>(value);
    }

    public class With<T>
    {
        private readonly T value;

        public With(T value)
        {
            this.value = value;
        }


        public void Assert(Action<T> action) => action(value);
    }
}
