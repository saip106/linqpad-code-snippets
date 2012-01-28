<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	int answer = await GetAnswerToLifeUniverseAndEverything();
	answer.Dump();
}

Task<int> GetAnswerToLifeUniverseAndEverything ()
{
	var tcs = new TaskCompletionSource<int>();
	new Timer (_ => tcs.SetResult (42)).Change (4000, -1);
	return tcs.Task;
}