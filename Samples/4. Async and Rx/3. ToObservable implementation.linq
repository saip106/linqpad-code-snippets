<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Reference Relative="System.Reactive.dll">&lt;Personal&gt;\LINQPad Queries\TechEd Async\4. Async and Rx\System.Reactive.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{
}

IObservable<T> ToObservable<T> (Task<T> task)
{
	return Observable.Create<T> (async o => 
	{
		o.OnNext (await task);
		o.OnCompleted(); 
	});
}