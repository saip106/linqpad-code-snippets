<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	Task<int> task = GetAnswerToLifeUniverseAndEverything();
	int answer = await task;
	answer.Dump();
}

async Task<int> GetAnswerToLifeUniverseAndEverything ()
{
	await TaskEx.Delay (4000);
	return 42;
}