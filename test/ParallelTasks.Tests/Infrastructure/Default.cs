using System;
using System.Linq;

namespace ParallelTasks.Tests
{
    public static class Default
    {
        private static T Of<T>() => default(T);
        
        public static object Of(Type t)
        {
            return typeof(Default)
                .GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .First()
                .MakeGenericMethod(t)
                .Invoke(null, new object[] { });
        }
    }
}
