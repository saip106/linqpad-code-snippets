<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var ab = new ActionBlock<int> (
	async i => 
	{
		await TaskEx.Delay (1000);
		Console.WriteLine (i);
	}
);

for (int i = 0; i < 10; i++)
	ab.Post (i);

Console.WriteLine ("Finished posting");

ab.Dump(); 