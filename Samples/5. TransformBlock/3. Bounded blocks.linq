<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var tb = new TransformBlock<int, int> (i => i * 10);

var ab1 = new ActionBlock<int> (
	i => 
	{
		Thread.Sleep (60000);
		Console.WriteLine (i);
	}
	, new ExecutionDataflowBlockOptions { BoundedCapacity = 4 }
);

var ab2 = new ActionBlock<int> (
	i => 
	{
		Thread.Sleep (60000);
		Console.WriteLine (i);
	}
	, new ExecutionDataflowBlockOptions { BoundedCapacity = 4 }
);

tb.LinkTo (ab1);
tb.LinkTo (ab2);

for (int i = 0; i < 12; i++)
	tb.Post (i);

tb.Dump();
ab1.Dump();
ab2.Dump();