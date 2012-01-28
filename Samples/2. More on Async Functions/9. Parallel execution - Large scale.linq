<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	Task<int>[] tasks = Enumerable.Range (0, 100000)
		.Select (_ => GetAnswerToLifeUniverseAndEverything())
		.ToArray();
	
	int[] answers = await TaskEx.WhenAll (tasks);
	
	int i = 0;
	foreach (int answer in answers) 
		Console.WriteLine (i++ + " - " + answer);
}

async Task<int> GetAnswerToLifeUniverseAndEverything ()
{
	await TaskEx.Delay (4000);
	return 42;
}