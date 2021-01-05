using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace ParallelTasks
{
    public static partial class Tasks
    {
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2>> WhenAll<T1, T2>(Task<T1> task1, Task<T2> task2)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2>> WhenAll<T1, T2>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2>> WhenAll<T1, T2>(Func<Task<T1>> task1, Func<Task<T2>> task2)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2>> WhenAll<T1, T2>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2>> WhenAll<T1, T2>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2>> WhenAll<T1, T2>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2>(Task<T1> task1, Task<T2> task2)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2>(Func<Task<T1>> task1, Func<Task<T2>> task2)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2>(Task<T1> task1, Task<T2> task2)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2>(Func<Task<T1>> task1, Func<Task<T2>> task2)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3>> WhenAll<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3>> WhenAll<T1, T2, T3>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3>> WhenAll<T1, T2, T3>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3>> WhenAll<T1, T2, T3>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3>> WhenAll<T1, T2, T3>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3>> WhenAll<T1, T2, T3>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18, Task<T19> task19)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18, (string name, Task<T19> task) task19)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18, Func<Task<T19>> task19)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18, (string name, Func<Task<T19>> task) task19)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, Func<CancellationToken, Task<T19>> task19, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, (string name, Func<CancellationToken, Task<T19>> operation) task19, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18, Task<T19> task19)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18, (string name, Task<T19> task) task19)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18, Func<Task<T19>> task19)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18, (string name, Func<Task<T19>> task) task19)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, Func<CancellationToken, Task<T19>> task19, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, (string name, Func<CancellationToken, Task<T19>> operation) task19, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18, Task<T19> task19)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18, (string name, Task<T19> task) task19)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18, Func<Task<T19>> task19)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18, (string name, Func<Task<T19>> task) task19)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, Func<CancellationToken, Task<T19>> task19, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, (string name, Func<CancellationToken, Task<T19>> operation) task19, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask());
#endif

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18, Task<T19> task19, Task<T20> task20)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.FromResults(x.Result));
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18, (string name, Task<T19> task) task19, (string name, Task<T20> task) task20)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18, Func<Task<T19>> task19, Func<Task<T20>> task20)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18, (string name, Func<Task<T19>> task) task19, (string name, Func<Task<T20>> task) task20)
			=> Tasks.WhenAll(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, Func<CancellationToken, Task<T19>> task19, Func<CancellationToken, Task<T20>> task20, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, (string name, Func<CancellationToken, Task<T19>> operation) task19, (string name, Func<CancellationToken, Task<T20>> operation) task20, CancellationToken cancellationToken)
			=> Tasks.WhenAll(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask())
				.ContinueWith(x => 
					TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.FromResults(x.Result));

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18, Task<T19> task19, Task<T20> task20)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18, (string name, Task<T19> task) task19, (string name, Task<T20> task) task20)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18, Func<Task<T19>> task19, Func<Task<T20>> task20)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18, (string name, Func<Task<T19>> task) task19, (string name, Func<Task<T20>> task) task20)
			=> Tasks.WhenAny(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, Func<CancellationToken, Task<T19>> task19, Func<CancellationToken, Task<T20>> task20, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static Task<ITaskResult> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, (string name, Func<CancellationToken, Task<T19>> operation) task19, (string name, Func<CancellationToken, Task<T20>> operation) task20, CancellationToken cancellationToken)
			=> Tasks.WhenAny(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

#if NETSTANDARD2_PLUS
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16, Task<T17> task17, Task<T18> task18, Task<T19> task19, Task<T20> task20)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());
		
		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Task<T1> task) task1, (string name, Task<T2> task) task2, (string name, Task<T3> task) task3, (string name, Task<T4> task) task4, (string name, Task<T5> task) task5, (string name, Task<T6> task) task6, (string name, Task<T7> task) task7, (string name, Task<T8> task) task8, (string name, Task<T9> task) task9, (string name, Task<T10> task) task10, (string name, Task<T11> task) task11, (string name, Task<T12> task) task12, (string name, Task<T13> task) task13, (string name, Task<T14> task) task14, (string name, Task<T15> task) task15, (string name, Task<T16> task) task16, (string name, Task<T17> task) task17, (string name, Task<T18> task) task18, (string name, Task<T19> task) task19, (string name, Task<T20> task) task20)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Func<Task<T1>> task1, Func<Task<T2>> task2, Func<Task<T3>> task3, Func<Task<T4>> task4, Func<Task<T5>> task5, Func<Task<T6>> task6, Func<Task<T7>> task7, Func<Task<T8>> task8, Func<Task<T9>> task9, Func<Task<T10>> task10, Func<Task<T11>> task11, Func<Task<T12>> task12, Func<Task<T13>> task13, Func<Task<T14>> task14, Func<Task<T15>> task15, Func<Task<T16>> task16, Func<Task<T17>> task17, Func<Task<T18>> task18, Func<Task<T19>> task19, Func<Task<T20>> task20)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Func<Task<T1>> task) task1, (string name, Func<Task<T2>> task) task2, (string name, Func<Task<T3>> task) task3, (string name, Func<Task<T4>> task) task4, (string name, Func<Task<T5>> task) task5, (string name, Func<Task<T6>> task) task6, (string name, Func<Task<T7>> task) task7, (string name, Func<Task<T8>> task) task8, (string name, Func<Task<T9>> task) task9, (string name, Func<Task<T10>> task) task10, (string name, Func<Task<T11>> task) task11, (string name, Func<Task<T12>> task) task12, (string name, Func<Task<T13>> task) task13, (string name, Func<Task<T14>> task) task14, (string name, Func<Task<T15>> task) task15, (string name, Func<Task<T16>> task) task16, (string name, Func<Task<T17>> task) task17, (string name, Func<Task<T18>> task) task18, (string name, Func<Task<T19>> task) task19, (string name, Func<Task<T20>> task) task20)
			=> Tasks.WhenEach(task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Func<CancellationToken, Task<T1>> task1, Func<CancellationToken, Task<T2>> task2, Func<CancellationToken, Task<T3>> task3, Func<CancellationToken, Task<T4>> task4, Func<CancellationToken, Task<T5>> task5, Func<CancellationToken, Task<T6>> task6, Func<CancellationToken, Task<T7>> task7, Func<CancellationToken, Task<T8>> task8, Func<CancellationToken, Task<T9>> task9, Func<CancellationToken, Task<T10>> task10, Func<CancellationToken, Task<T11>> task11, Func<CancellationToken, Task<T12>> task12, Func<CancellationToken, Task<T13>> task13, Func<CancellationToken, Task<T14>> task14, Func<CancellationToken, Task<T15>> task15, Func<CancellationToken, Task<T16>> task16, Func<CancellationToken, Task<T17>> task17, Func<CancellationToken, Task<T18>> task18, Func<CancellationToken, Task<T19>> task19, Func<CancellationToken, Task<T20>> task20, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());

		[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
		public static IAsyncEnumerable<ITaskResult> WhenEach<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((string name, Func<CancellationToken, Task<T1>> operation) task1, (string name, Func<CancellationToken, Task<T2>> operation) task2, (string name, Func<CancellationToken, Task<T3>> operation) task3, (string name, Func<CancellationToken, Task<T4>> operation) task4, (string name, Func<CancellationToken, Task<T5>> operation) task5, (string name, Func<CancellationToken, Task<T6>> operation) task6, (string name, Func<CancellationToken, Task<T7>> operation) task7, (string name, Func<CancellationToken, Task<T8>> operation) task8, (string name, Func<CancellationToken, Task<T9>> operation) task9, (string name, Func<CancellationToken, Task<T10>> operation) task10, (string name, Func<CancellationToken, Task<T11>> operation) task11, (string name, Func<CancellationToken, Task<T12>> operation) task12, (string name, Func<CancellationToken, Task<T13>> operation) task13, (string name, Func<CancellationToken, Task<T14>> operation) task14, (string name, Func<CancellationToken, Task<T15>> operation) task15, (string name, Func<CancellationToken, Task<T16>> operation) task16, (string name, Func<CancellationToken, Task<T17>> operation) task17, (string name, Func<CancellationToken, Task<T18>> operation) task18, (string name, Func<CancellationToken, Task<T19>> operation) task19, (string name, Func<CancellationToken, Task<T20>> operation) task20, CancellationToken cancellationToken)
			=> Tasks.WhenEach(cancellationToken, task1.AsTask(), task2.AsTask(), task3.AsTask(), task4.AsTask(), task5.AsTask(), task6.AsTask(), task7.AsTask(), task8.AsTask(), task9.AsTask(), task10.AsTask(), task11.AsTask(), task12.AsTask(), task13.AsTask(), task14.AsTask(), task15.AsTask(), task16.AsTask(), task17.AsTask(), task18.AsTask(), task19.AsTask(), task20.AsTask());
#endif

    }
}
