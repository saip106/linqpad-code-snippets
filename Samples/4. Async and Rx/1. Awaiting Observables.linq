<Query Kind="Statements">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Reference Relative="System.Reactive.dll">&lt;Personal&gt;\LINQPad Queries\TechEd Async\4. Async and Rx\System.Reactive.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

string hello = await Observable.Return ("Hello, world");
hello.Dump();

await Observable.Timer (TimeSpan.FromSeconds (1));
"A second passed".Dump();