<Query Kind="Statements">
  <Reference Relative="System.Reactive.dll">&lt;Personal&gt;\LINQPad Queries\TechEd Dataflow\7. Rx Interop\System.Reactive.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Corporation\TPL Dataflow\System.Threading.Tasks.Dataflow.dll</Reference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var ab = new ActionBlock<int> (i => Console.WriteLine (i));

Observable.Range (0, 10).Subscribe (ab.AsObserver ());