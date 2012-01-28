<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var ab = new ActionBlock<int> (
	i => 
	{
		Thread.Sleep (1000);
		Console.WriteLine (i);
	},
	new ExecutionDataflowBlockOptions { MaxDegreeOfParallelism = 2 } 
);

for (int i = 0; i < 20; i++)
	ab.Post (i);

ab.Dump();