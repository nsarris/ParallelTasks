using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks
{
    internal class NamedTaskFactory<T>
    {
        private readonly Func<CancellationToken, Task<T>> taskFactoryWithCancellation;
        private readonly Func<Task<T>> taskFactory;
        private readonly Task<T> task;
        private readonly string name;
        private readonly int? index;

        public NamedTaskFactory(Func<CancellationToken, Task<T>> taskFactory, int? index)
            : this(taskFactory, null, index)
        {
        }

        public NamedTaskFactory(Func<CancellationToken, Task<T>> taskFactory, string name, int? index = null)
        {
            this.taskFactoryWithCancellation = taskFactory;
            this.name = name;
            this.index = index;
        }

        public NamedTaskFactory(Func<Task<T>> taskFactory, int? index)
            : this(taskFactory, null, index)
        {
        }

        public NamedTaskFactory(Func<Task<T>> taskFactory, string name, int? index = null)
        {
            this.taskFactory = taskFactory;
            this.name = name;
            this.index = index;
        }

        public NamedTaskFactory(Task<T> task, int? index)
            : this(task, null, index)
        {
        }

        public NamedTaskFactory(Task<T> task, string name, int? index)
        {
            this.task = task;
            this.name = name;
            this.index = index;
        }

        public Task<ITaskResult<T>> GetTask(CancellationToken cancellationToken)
        {
            try
            {
                return
                    (task ?? taskFactory?.Invoke() ?? taskFactoryWithCancellation.Invoke(cancellationToken))
                    .AsTaskResult(name, index);
            }
            catch (Exception e)
            {
                return Task.FromResult(TaskResult.FromException<T>(e, name, index));
            }
        }
    }

}

