<Query Kind="Statements">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var tb = new TransformBlock<int, int> (
	i => 
	{
		Thread.Sleep (1000);
		return i * 10;
	}
);

var ab = new ActionBlock<int> (
	i => 
	{
		Thread.Sleep (2000);
		Console.WriteLine (i);
	}
);

tb.LinkTo (ab);

for (int i = 0; i < 10; i++)
	tb.Post (i);

tb.Dump();
ab.Dump();