<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var ab = new ActionBlock<int> (
	i => 
	{
		Thread.Sleep (500);
		Console.WriteLine (i);
	}
);

for (int i = 0; i < 10; i++)
	ab.Post (i);

ab.Complete();

Console.WriteLine ("Finished posting");

ab.Completion.Wait();
Console.WriteLine ("Completed");