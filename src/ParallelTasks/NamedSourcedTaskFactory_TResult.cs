using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks
{
    internal class NamedSourcedTaskFactory<TSource, TResult>
    {
        private readonly Func<TSource, CancellationToken, Task<TResult>> taskFactoryWithCancellation;
        private readonly Func<TSource, Task<TResult>> taskFactory;
        private readonly TSource source;

        private readonly string name;
        private readonly int? index;

        public NamedSourcedTaskFactory(Func<TSource, CancellationToken, Task<TResult>> taskFactory, TSource source, int? index)
            : this(taskFactory, source, null, index)
        {
        }

        public NamedSourcedTaskFactory(Func<TSource, CancellationToken, Task<TResult>> taskFactory, TSource source, string name, int? index = null)
        {
            this.taskFactoryWithCancellation = taskFactory;
            this.source = source;
            this.name = name;
            this.index = index;
        }

        public NamedSourcedTaskFactory(Func<TSource, Task<TResult>> taskFactory, TSource source, int? index)
            : this(taskFactory, source, null, index)
        {
        }

        public NamedSourcedTaskFactory(Func<TSource, Task<TResult>> taskFactory, TSource source, string name, int? index = null)
        {
            this.taskFactory = taskFactory;
            this.source = source;
            this.name = name;
            this.index = index;
        }

        public Task<ISourcedTaskResult<TSource, TResult>> GetTask(CancellationToken cancellationToken)
        {
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return Task.FromResult(TaskResult.FromCancellation<TSource, TResult>(source, name, index));
                }

                return
                    (taskFactory?.Invoke(source) ?? taskFactoryWithCancellation.Invoke(source, cancellationToken))
                    .AsTaskResult(source, name, index);
            }
            catch (Exception e)
            {
                return Task.FromResult(TaskResult.FromException<TSource, TResult>(source, e, name, index));
            }
        }
    }
}

