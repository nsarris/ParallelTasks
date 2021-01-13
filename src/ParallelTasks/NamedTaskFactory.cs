using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks
{
    internal class NamedTaskFactory
    {
        private readonly Func<CancellationToken, Task> taskFactoryWithCancellation;
        private readonly Func<Task> taskFactory;
        private readonly Task task;
        private readonly string name;
        private readonly int? index;

        public NamedTaskFactory(Func<CancellationToken, Task> taskFactory, int? index)
            : this(taskFactory, null, index)
        {
        }

        public NamedTaskFactory(Func<CancellationToken, Task> taskFactory, string name, int? index = null)
        {
            this.taskFactoryWithCancellation = taskFactory;
            this.name = name;
            this.index = index;
        }

        public NamedTaskFactory(Func<Task> taskFactory, int? index)
            : this(taskFactory, null, index)
        {
        }

        public NamedTaskFactory(Func<Task> taskFactory, string name, int? index = null)
        {
            this.taskFactory = taskFactory;
            this.name = name;
            this.index = index;
        }

        public NamedTaskFactory(Task task, int? index)
            : this(task, null, index)
        {
        }

        public NamedTaskFactory(Task task, string name, int? index)
        {
            this.task = task;
            this.name = name;
            this.index = index;
        }

        public Task<ITaskResult> GetTask(CancellationToken cancellationToken)
        {
            try
            {
                return
                    (task ?? taskFactory?.Invoke() ?? taskFactoryWithCancellation.Invoke(cancellationToken))
                    .AsTaskResult(name, index);
            }
            catch (Exception e)
            {
                return Task.FromResult(TaskResult.FromException(e, name, index));
            }
        }
    }

}

