using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MZTraceProfiler.Tests
{
	[TestClass]
	public class TraceProfilerTests
	{
		[TestMethod]
		public void VariableTraceListener_Will_Output_Correct_Value()
		{
			var output = new Listener();
			var variableTraceListener = new VariableTraceListener(ref output);
			const string expected = "Listener Test";

			Trace.Listeners.Add(variableTraceListener);
			Trace.WriteLine(expected);

			Assert.AreEqual(expected, output.Message);
		}

		[TestMethod]
		public void TraceProfiler_Will_Profile_DurationOf_Sleep2000()
		{
			var output = new Listener();
			var variableTraceListener = new VariableTraceListener(ref output);
			Trace.Listeners.Add(variableTraceListener);

			using (new TraceProfiler("Cat"))
			{
				Thread.Sleep(2000);
			}

			Assert.AreEqual("x", output.Message);
		}

		public class Listener
		{
			public string Message;
		}
	}
}
