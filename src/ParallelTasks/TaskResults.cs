using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace ParallelTasks
{
    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2)
        {
            Result1 = result1;
			Result2 = result2;

			results = new ITaskResult[] { result1, result2 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>) AsTuple()
            => (Result1, Result2);

        public (T1, T2) AsTupleOfValues()
            => (Result1.Value, Result2.Value);

        internal static TaskResults<T1, T2> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;

			results = new ITaskResult[] { result1, result2, result3 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>) AsTuple()
            => (Result1, Result2, Result3);

        public (T1, T2, T3) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value);

        internal static TaskResults<T1, T2, T3> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;

			results = new ITaskResult[] { result1, result2, result3, result4 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>) AsTuple()
            => (Result1, Result2, Result3, Result4);

        public (T1, T2, T3, T4) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value);

        internal static TaskResults<T1, T2, T3, T4> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;

			results = new ITaskResult[] { result1, result2, result3, result4, result5 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5);

        public (T1, T2, T3, T4, T5) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value);

        internal static TaskResults<T1, T2, T3, T4, T5> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6);

        public (T1, T2, T3, T4, T5, T6) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7);

        public (T1, T2, T3, T4, T5, T6, T7) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8);

        public (T1, T2, T3, T4, T5, T6, T7, T8) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14, ITaskResult<T15> result15)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;
			Result15 = result15;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }
		public ITaskResult<T15> Result15 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>, ITaskResult<T15>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14, Result15);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value, Result15.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13], (ITaskResult<T15>)indexedResults[14]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14, ITaskResult<T15> result15, ITaskResult<T16> result16)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;
			Result15 = result15;
			Result16 = result16;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }
		public ITaskResult<T15> Result15 { get; }
		public ITaskResult<T16> Result16 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>, ITaskResult<T15>, ITaskResult<T16>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14, Result15, Result16);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value, Result15.Value, Result16.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13], (ITaskResult<T15>)indexedResults[14], (ITaskResult<T16>)indexedResults[15]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14, ITaskResult<T15> result15, ITaskResult<T16> result16, ITaskResult<T17> result17)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;
			Result15 = result15;
			Result16 = result16;
			Result17 = result17;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16, result17 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }
		public ITaskResult<T15> Result15 { get; }
		public ITaskResult<T16> Result16 { get; }
		public ITaskResult<T17> Result17 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>, ITaskResult<T15>, ITaskResult<T16>, ITaskResult<T17>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14, Result15, Result16, Result17);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value, Result15.Value, Result16.Value, Result17.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13], (ITaskResult<T15>)indexedResults[14], (ITaskResult<T16>)indexedResults[15], (ITaskResult<T17>)indexedResults[16]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14, ITaskResult<T15> result15, ITaskResult<T16> result16, ITaskResult<T17> result17, ITaskResult<T18> result18)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;
			Result15 = result15;
			Result16 = result16;
			Result17 = result17;
			Result18 = result18;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16, result17, result18 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }
		public ITaskResult<T15> Result15 { get; }
		public ITaskResult<T16> Result16 { get; }
		public ITaskResult<T17> Result17 { get; }
		public ITaskResult<T18> Result18 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>, ITaskResult<T15>, ITaskResult<T16>, ITaskResult<T17>, ITaskResult<T18>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14, Result15, Result16, Result17, Result18);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value, Result15.Value, Result16.Value, Result17.Value, Result18.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13], (ITaskResult<T15>)indexedResults[14], (ITaskResult<T16>)indexedResults[15], (ITaskResult<T17>)indexedResults[16], (ITaskResult<T18>)indexedResults[17]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14, ITaskResult<T15> result15, ITaskResult<T16> result16, ITaskResult<T17> result17, ITaskResult<T18> result18, ITaskResult<T19> result19)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;
			Result15 = result15;
			Result16 = result16;
			Result17 = result17;
			Result18 = result18;
			Result19 = result19;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16, result17, result18, result19 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }
		public ITaskResult<T15> Result15 { get; }
		public ITaskResult<T16> Result16 { get; }
		public ITaskResult<T17> Result17 { get; }
		public ITaskResult<T18> Result18 { get; }
		public ITaskResult<T19> Result19 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>, ITaskResult<T15>, ITaskResult<T16>, ITaskResult<T17>, ITaskResult<T18>, ITaskResult<T19>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14, Result15, Result16, Result17, Result18, Result19);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value, Result15.Value, Result16.Value, Result17.Value, Result18.Value, Result19.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13], (ITaskResult<T15>)indexedResults[14], (ITaskResult<T16>)indexedResults[15], (ITaskResult<T17>)indexedResults[16], (ITaskResult<T18>)indexedResults[17], (ITaskResult<T19>)indexedResults[18]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IEnumerable<ITaskResult>
    {
		private readonly IEnumerable<ITaskResult> results;
        
        public TaskResults(ITaskResult<T1> result1, ITaskResult<T2> result2, ITaskResult<T3> result3, ITaskResult<T4> result4, ITaskResult<T5> result5, ITaskResult<T6> result6, ITaskResult<T7> result7, ITaskResult<T8> result8, ITaskResult<T9> result9, ITaskResult<T10> result10, ITaskResult<T11> result11, ITaskResult<T12> result12, ITaskResult<T13> result13, ITaskResult<T14> result14, ITaskResult<T15> result15, ITaskResult<T16> result16, ITaskResult<T17> result17, ITaskResult<T18> result18, ITaskResult<T19> result19, ITaskResult<T20> result20)
        {
            Result1 = result1;
			Result2 = result2;
			Result3 = result3;
			Result4 = result4;
			Result5 = result5;
			Result6 = result6;
			Result7 = result7;
			Result8 = result8;
			Result9 = result9;
			Result10 = result10;
			Result11 = result11;
			Result12 = result12;
			Result13 = result13;
			Result14 = result14;
			Result15 = result15;
			Result16 = result16;
			Result17 = result17;
			Result18 = result18;
			Result19 = result19;
			Result20 = result20;

			results = new ITaskResult[] { result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16, result17, result18, result19, result20 };
        }

		
		public bool AllCompletedSuccessfully => results.AllCompletedSuccessfully();

        public ITaskResult<T1> Result1 { get; }
		public ITaskResult<T2> Result2 { get; }
		public ITaskResult<T3> Result3 { get; }
		public ITaskResult<T4> Result4 { get; }
		public ITaskResult<T5> Result5 { get; }
		public ITaskResult<T6> Result6 { get; }
		public ITaskResult<T7> Result7 { get; }
		public ITaskResult<T8> Result8 { get; }
		public ITaskResult<T9> Result9 { get; }
		public ITaskResult<T10> Result10 { get; }
		public ITaskResult<T11> Result11 { get; }
		public ITaskResult<T12> Result12 { get; }
		public ITaskResult<T13> Result13 { get; }
		public ITaskResult<T14> Result14 { get; }
		public ITaskResult<T15> Result15 { get; }
		public ITaskResult<T16> Result16 { get; }
		public ITaskResult<T17> Result17 { get; }
		public ITaskResult<T18> Result18 { get; }
		public ITaskResult<T19> Result19 { get; }
		public ITaskResult<T20> Result20 { get; }

        public (ITaskResult<T1>, ITaskResult<T2>, ITaskResult<T3>, ITaskResult<T4>, ITaskResult<T5>, ITaskResult<T6>, ITaskResult<T7>, ITaskResult<T8>, ITaskResult<T9>, ITaskResult<T10>, ITaskResult<T11>, ITaskResult<T12>, ITaskResult<T13>, ITaskResult<T14>, ITaskResult<T15>, ITaskResult<T16>, ITaskResult<T17>, ITaskResult<T18>, ITaskResult<T19>, ITaskResult<T20>) AsTuple()
            => (Result1, Result2, Result3, Result4, Result5, Result6, Result7, Result8, Result9, Result10, Result11, Result12, Result13, Result14, Result15, Result16, Result17, Result18, Result19, Result20);

        public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20) AsTupleOfValues()
            => (Result1.Value, Result2.Value, Result3.Value, Result4.Value, Result5.Value, Result6.Value, Result7.Value, Result8.Value, Result9.Value, Result10.Value, Result11.Value, Result12.Value, Result13.Value, Result14.Value, Result15.Value, Result16.Value, Result17.Value, Result18.Value, Result19.Value, Result20.Value);

        internal static TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> FromResults(IEnumerable<ITaskResult> results)
        {
            if (!(results is IList<ITaskResult> indexedResults))
                indexedResults = results.ToList();

            return new TaskResults<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((ITaskResult<T1>)indexedResults[0], (ITaskResult<T2>)indexedResults[1], (ITaskResult<T3>)indexedResults[2], (ITaskResult<T4>)indexedResults[3], (ITaskResult<T5>)indexedResults[4], (ITaskResult<T6>)indexedResults[5], (ITaskResult<T7>)indexedResults[6], (ITaskResult<T8>)indexedResults[7], (ITaskResult<T9>)indexedResults[8], (ITaskResult<T10>)indexedResults[9], (ITaskResult<T11>)indexedResults[10], (ITaskResult<T12>)indexedResults[11], (ITaskResult<T13>)indexedResults[12], (ITaskResult<T14>)indexedResults[13], (ITaskResult<T15>)indexedResults[14], (ITaskResult<T16>)indexedResults[15], (ITaskResult<T17>)indexedResults[16], (ITaskResult<T18>)indexedResults[17], (ITaskResult<T19>)indexedResults[18], (ITaskResult<T20>)indexedResults[19]);
        }

        public IEnumerator<ITaskResult> GetEnumerator() => results.GetEnumerator();
        
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
