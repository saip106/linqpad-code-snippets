<Query Kind="Statements">
  <Reference Relative="System.Reactive.dll">&lt;Personal&gt;\LINQPad Queries\TechEd Dataflow\7. Rx Interop\System.Reactive.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
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

for (int i = 0; i < 10; i++)
	tb.Post (i);
	
tb.Complete();
tb.AsObservable().Dump();