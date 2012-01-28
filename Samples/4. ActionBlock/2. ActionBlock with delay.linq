<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var ab = new ActionBlock<int> (
	i => 
	{
		Thread.Sleep (1000);
		Console.WriteLine (i);
	}
);

for (int i = 0; i < 10; i++)
	ab.Post (i);

Console.WriteLine ("Finished posting");

//ab.Dump();