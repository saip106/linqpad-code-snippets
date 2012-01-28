<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Reactive Extensions SDK\v1.1.10621\Binaries\.NETFramework\v4.0\System.Reactive.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Reactive Extensions SDK\v1.1.10621\Binaries\.NETFramework\v4.0\Microsoft.Reactive.Testing.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Reactive Extensions SDK\v1.1.10621\Binaries\.NETFramework\v4.0\System.Reactive.Providers.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Reactive Extensions SDK\v1.1.10621\Binaries\.NETFramework\v4.0\System.Reactive.Windows.Forms.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Reactive Extensions SDK\v1.1.10621\Binaries\.NETFramework\v4.0\System.Reactive.Windows.Threading.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var tb = new TransformBlock<int, int> (
	i => 
	{
		Thread.Sleep (1000);
		return i * 10;
	}
);

for (int i = 0; i < 15; i++)
	tb.Post (i);

tb.Dump();

// How do we get stuff out?