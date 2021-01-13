using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks
{
    internal class NamedSourcedTaskFactory<TSource>
    {
        private readonly Func<TSource, CancellationToken, Task> taskFactoryWithCancellation;
        private readonly Func<TSource, Task> taskFactory;
        private readonly TSource source;
        private readonly string name;
        private readonly int? index;

        public NamedSourcedTaskFactory(Func<TSource, CancellationToken, Task> taskFactory, TSource source, int? index)
            : this(taskFactory, source, null, index)
        {
        }

        public NamedSourcedTaskFactory(Func<TSource, CancellationToken, Task> taskFactory, TSource source, string name, int? index = null)
        {
            this.taskFactoryWithCancellation = taskFactory;
            this.source = source;
            this.name = name;
            this.index = index;
        }

        public NamedSourcedTaskFactory(Func<TSource, Task> taskFactory, TSource source, int? index)
            : this(taskFactory, source, null, index)
        {
        }

        public NamedSourcedTaskFactory(Func<TSource, Task> taskFactory, TSource source, string name, int? index = null)
        {
            this.taskFactory = taskFactory;
            this.source = source;
            this.name = name;
            this.index = index;
        }

        public Task<ISourcedTaskResult<TSource>> GetTask(CancellationToken cancellationToken)
        {
            try
            {
                return
                    (taskFactory?.Invoke(source) ?? taskFactoryWithCancellation.Invoke(source, cancellationToken))
                    .AsTaskResult(source, name, index);
            }
            catch (Exception e)
            {
                return Task.FromResult(TaskResult.FromException(source, e, name, index));
            }
        }
    }
}

