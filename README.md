# Trace Profiler (for .net) aka MZTraceProfiler

Quickly wrap a block of code with TraceProfiler to see how long it's taking to execute. The duration will be automatically sent to your projects Trace output.

#Installing via NuGet

Easily add this package to your Project using NuGet. You can find the NuGet package [here](http://nuget.org/packages/MZTraceProfiler).

## IMPLEMENTATION:

    using (new TraceProfiler("Load Events"))
    {
        Thread.Sleep(1000);
    }
    
Now that the TraceProfiler has disposed of itself the duration of the code block with the name "Load Events" will be sent to the TraceListener. Example:

	14/07/2006 1:00:05 AM UTC - Load Events duration (ms): 2000.7156
	
## Trace Listeners

Haven't setup your TraceListeners? Here's an example that should get you going.
	
	<system.diagnostics>
		<trace autoflush="true" indentsize="4">
			<listeners>
				<!-- Trace to Console -->
				<add name="configConsoleListener" type="System.Diagnostics.ConsoleTraceListener" />
				<!-- Trace to File -->
				<!-- <add name="configFileListener" type="System.Diagnostics.TextWriterTraceListener" initializeData="D:\webservers\AnziifUAT\uploads\TraceOutput.log" /> -->
			</listeners>
		</trace>
	</system.diagnostics>
	
## REQUIREMENTS:

Requires .Net 2.

## LICENSE:

(The MIT License)

Copyright (c) 2011 Ben Clark-Robinson, ben.clarkrobinson@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
'Software'), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
