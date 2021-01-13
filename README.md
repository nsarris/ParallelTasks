# ParallelTasks

Awaiting multiple tasks using the Task Parallel Library and Task.WhenAll / Task.WhenAny can be too verbose syntactically  as you need to assign each task to a variable, await the collection of tasks and then inspect each task individual for exceptions in case an AggregateException is thrown during parallel processing.

The aim of this library is to simplify the syntax of performing parrellel task operations. To achieve this, all tasks handled by ParallelTasks are transformed to Task<ITaskResult> (or any of the ITaskResult interface's generic derivatives). In this way tasks become exceptionless, meaning they all run to completion and any possible exceptions are encapsulated in the resulting ITaskResult, along with any result and the completed task status. In addition, as opposed to Task.WhenAll all results are strongly typed.

The main entry point is Tasks.WhenAll and Tasks.WhenAny to match the original Task.WhenAll and Task.WhenAny. Additionally Tasks.WhenEach is added to support asynchronous enumaration using IAsyncAnumerable (NetStandard 2.0 onwards)

This will effectively transfrom this:

```csharp
var task1 = PerformTask1Async();
var task2 = PerformTask2Async();
var task3 = PerformTask3Async();

try
{
	var result = await Task.WhenAll(new [] { task1, task2, task3 });
}
catch(Exception e)
{
	if (task1.Exception != null)
    {
        //Handle error      
    }
	if (task2.Exception != null)
    {
        //Handle error
    }
	if (task3.Exception != null)
    {
		//Handle error
    }
}

if (task1.Exception != null
	&& task2.Exception != null
	&& task2.Exception != null)
{
	//Success
}
```

to:

```csharp
var results = await Tasks.WhenAll(
	PerformTask1Async()
	PerformTask2Async()
	PerformTask3Async());
	
if (results.AllCompletedSuccessfully)
{
	//Success
}
else
{
	foreach(var taskResult in results.GetFailedOrCanceled()))
    {
        //Handle task error
    }
}
```

or for individual processing:

```csharp
var results = await Tasks.WhenAll(
	PerformTask1Async()
	PerformTask2Async()
	PerformTask3Async());
	
var (task1Result, task2Result, task3Result) = results.AsTuple();

//Handle each strongly typed result individually
```

Other features include:
- Strongly typed results for WhenAll when awaiting multiple Task<T> with different result Types.
- ITaskResult includes the result if the underlying Task is Task<T>.
- Indexing: All tasks and results are indexed to match result with task/
- Naming: Tasks can be named to match result with task or for logging.
- Producing tasks from an enumerable source, producing results that encapsulate the originating source value.
- DegreeOfParallelism can be set to restrict maximum parallel execution. Overriding this value for debugging is also supported.
- WhenAll results can be returned as a Tuple to provide easily named results.