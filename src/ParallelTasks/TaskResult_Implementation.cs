using System;
using System.Threading.Tasks;

namespace ParallelTasks
{
    internal abstract class TaskResultBase
    {
        protected TaskResultBase(Exception exception, string name = null, int? index = null)
        {
            if (exception is null)
                throw new ArgumentNullException(nameof(exception));

            Name = name;
            Index = index;

            Exception = UnWrapException(exception);

            Status = GetState(TaskStatus.Faulted, Exception);
            
            IsCanceled = Status == TaskResultStatus.Canceled;
            IsCompleted = Status == TaskResultStatus.Completed;
            IsFaulted = Status == TaskResultStatus.Faulted;
        }

        protected TaskResultBase(string name = null, int? index = null, TaskResultStatus status = TaskResultStatus.Completed)
        {
            Name = name;
            Index = index;

            Status = status;

            IsCanceled = Status == TaskResultStatus.Canceled;
            IsCompleted = Status == TaskResultStatus.Completed;
            IsFaulted = Status == TaskResultStatus.Faulted;
        }

        protected TaskResultBase(Task task, string name = null, int? index = null)
        {
            AssertTaskIsValid(task);

            Name = name;
            Index = index;

            Exception = UnWrapException(task.Exception);

            Status = GetState(task.Status, Exception);

            IsCanceled = Status == TaskResultStatus.Canceled;
            IsCompleted = Status == TaskResultStatus.Completed;
            IsFaulted = Status == TaskResultStatus.Faulted;
        }

        public string Name { get; }

        public int? Index { get; }

        public TaskResultStatus Status { get; }

        public Exception Exception { get; }

        public bool IsCanceled { get; }

        public bool IsCompleted { get; }

        public bool IsFaulted { get; }

        /// <summary>
        /// Validates the given task.
        /// </summary>
        /// <param name="task">The given task.</param>
        private void AssertTaskIsValid(Task task)
        {
            if (task is null)
                throw new ArgumentNullException(nameof(task));

            if (task.Status < TaskStatus.RanToCompletion)
                throw new ArgumentException($"TaskResult can only be constructed from a completed, faulted or canceled task. Task provider was in {task.Status} state.", nameof(task));
        }

        /// <summary>
        /// Infers the result state from the originating task status and a given exception.
        /// </summary>
        /// <param name="taskStatus">The status of the originating task.</param>
        /// <param name="exception">The exception that was occured.</param>
        /// <returns>The result of the completed task.</returns>
        private TaskResultStatus GetState(TaskStatus taskStatus, Exception exception)
        {
            return exception switch
            {
                OperationCanceledException _ => TaskResultStatus.Canceled,
                Exception _ => TaskResultStatus.Faulted,
                _ => taskStatus switch
                {
                    TaskStatus.RanToCompletion => TaskResultStatus.Completed,
                    TaskStatus.Faulted => TaskResultStatus.Faulted,
                    TaskStatus.Canceled => TaskResultStatus.Canceled,
                    _ => throw new ArgumentException($"TaskResult can only be constructed from a completed, faulted or cancled task. Task provider was in {taskStatus} snamee.", nameof(taskStatus))
                }
            };
        }

        /// <summary>
        /// Unwrapps an AggregateException.
        /// </summary>
        /// <param name="exception">The exception to unwrap.</param>
        /// <returns>The unwraped inner exception.</returns>
        private Exception UnWrapException(Exception exception)
        {
            if (exception is AggregateException aggregateException)
                return aggregateException.Flatten().InnerException;
            else
                return exception;
        }
    }

    internal class TaskResult<TResult> : TaskResultBase, ITaskResult<TResult>
    {
        public TResult Value { get; }

        public TaskResult(TResult value, string name, int? index = null)
            : base(name, index)
        {
            Value = value;
        }

        internal TaskResult(TaskResultStatus status, string name, int? index = null)
            :base(name, index, status)
        {
            
        }

        internal TaskResult(Exception exception, string name = null, int? index = null) 
            : base(exception, name, index)
        {
        }

        internal TaskResult(Task<TResult> task, string name = null, int? index = null) 
            : base(task, name, index)
        {
            if (task.Status == TaskStatus.RanToCompletion)
                Value = task.Result;
        }

        bool ITaskResult.IsVoid => false;

        object ITaskResult.Value => Value;
    }

    internal class VoidTaskResult : TaskResultBase, ITaskResult
    {
        bool ITaskResult.IsVoid => true;

        object ITaskResult.Value => null;

        public VoidTaskResult(string name, int? index) 
            : base(name, index)
        {
        }

        internal VoidTaskResult(TaskResultStatus status, string name, int? index = null)
            : base(name, index, status)
        {

        }

        internal VoidTaskResult(Exception exception, string name = null, int? index = null) 
            : base(exception, name, index)
        {
        }

        internal VoidTaskResult(Task task, string name = null, int? index = null) 
            : base(task, name, index)
        {
        }
    }

    internal class TaskResult<TSource, TResult> : TaskResult<TResult>, ISourcedTaskResult<TSource, TResult>
    {
        public TSource Source { get; }

        public TaskResult(TSource source, TResult value, string name, int? index = null) 
            : base(value, name, index)
        {
            Source = source;
        }

        internal TaskResult(TSource source, TaskResultStatus status, string name, int? index = null)
            : base(status, name, index)
        {
            Source = source;
        }

        internal TaskResult(TSource source, Exception exception, string name = null, int? index = null) 
            : base(exception, name, index)
        {
            Source = source;
        }

        internal TaskResult(TSource source, Task<TResult> task, string name = null, int? index = null)
            : base(task, name, index)
        {
            Source = source;
        }
    }

    internal class VoidTaskResult<TSource> : VoidTaskResult, ISourcedTaskResult<TSource>
    {
        public TSource Source { get; }

        public VoidTaskResult(TSource source, string name, int? index) 
            : base(name, index)
        {
            Source = source;
        }

        internal VoidTaskResult(TSource source, TaskResultStatus status, string name, int? index = null)
            : base(status, name, index)
        {
            Source = source;
        }

        internal VoidTaskResult(TSource source, Exception exception, string name = null, int? index = null) 
            : base(exception, name, index)
        {
            Source = source;
        }

        internal VoidTaskResult(TSource source, Task task, string name = null, int? index = null) 
            : base(task, name, index)
        {
            Source = source;
        }
    }
}

