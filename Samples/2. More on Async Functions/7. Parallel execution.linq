<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	Task<int> task = GetAnswerToLifeUniverseAndEverything();
	Task<int> task2 = GetAnswerToLifeUniverseAndEverything();
	Task<int> task3 = GetAnswerToLifeUniverseAndEverything();
	
	int answer = await task;
	int answer2 = await task2;
	int answer3 = await task3;
	
	answer.Dump();
	answer2.Dump();
	answer3.Dump();
}

async Task<int> GetAnswerToLifeUniverseAndEverything ()
{
	await TaskEx.Delay (4000);
	return 42;
}