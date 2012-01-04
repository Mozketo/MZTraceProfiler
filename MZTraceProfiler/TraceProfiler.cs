using System;
using System.Diagnostics;

namespace MZTraceProfiler
{
	public class TraceProfiler : IDisposable
	{
		protected string Name;
		protected Stopwatch Stopwatch;
		protected DateTime Begin;

		public TraceProfiler(string name)
		{
			Stopwatch = Stopwatch.StartNew();
			Begin = DateTime.UtcNow;
			Name = name;
		}

		public void Dispose()
		{
			Stopwatch.Stop();
			TimeSpan duration = Stopwatch.Elapsed;
			Trace.WriteLine(String.Format("{0} UTC - {1} duration (ms): {2}", Begin.ToUniversalTime(), Name, duration.TotalMilliseconds));
		}
	}
}
