using System.Diagnostics;

namespace MZTraceProfiler.Tests
{
    public class VariableTraceListener : TraceListener
    {
		private TraceProfilerTests.Listener _output;

		public VariableTraceListener(ref TraceProfilerTests.Listener output)
        {
            _output = output;
        }

    	public override void Write(string message)
    	{
    		_output.Message += message;
			
    	}

    	public override void WriteLine(string message)
    	{
			_output.Message += message;
    	}
    }
}
