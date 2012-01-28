<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	await Delay(2000);
	"Done".Dump();
}

Task Delay (int milliseconds)		// Asynchronous NON-BLOCKING method
{
	var tcs = new TaskCompletionSource<object>();
	new Timer (_ => tcs.SetResult (null)).Change (milliseconds, -1);
	return tcs.Task;
}