using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Reflection;

namespace ParallelTasks
{
    internal static class ReflectionHelper
    {
        private static Lazy<Type> voidTaskResultType = new Lazy<Type>(() => {
            var voidTaskType = VoidTask().GetType();
            if (voidTaskType.IsConstructedGenericType &&
                voidTaskType.GetGenericTypeDefinition() == typeof(Task<>))
                return voidTaskType.GenericTypeArguments[0];
            else
                return null;
        });

        private static async Task VoidTask() 
        {
#if NETSTANDARD2_PLUS
            await Task.CompletedTask;
#else
            await Task.Delay(0);
#endif
        }


        public static bool IsTaskOfT(this Task task, out Type elementType)
        {
            var type = task.GetType();

            elementType =
                typeOrAncestorSatisfies(type, isTaskOfT) ?
                type.GenericTypeArguments[0] :
                null;

            return elementType != null;

            static bool isTaskOfT(Type t) =>
                t.IsConstructedGenericType
                && t.GetGenericTypeDefinition() == typeof(Task<>)
                && t.GenericTypeArguments[0] != voidTaskResultType.Value;

            static bool typeOrAncestorSatisfies(Type type, Func<Type, bool> predicate)
            {
                while (type != null)
                {
                    if (predicate(type))
                        return true;

                    type = type
#if !NETSTANDARD2_PLUS
                        .GetTypeInfo()
#endif
                        .BaseType;
                }
                return false;
            }
        }

        public static MethodInfo ExtractMethod(Expression<Func<object>> methodCallLambda)
        {
            if (methodCallLambda.Body is MethodCallExpression methodCallExpression)
                return methodCallExpression.Method;

            throw new ArgumentException("Expression is not a method call expression.", nameof(methodCallLambda));
        }
    }
}
