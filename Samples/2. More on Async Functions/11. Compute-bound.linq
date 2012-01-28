<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	int answer = await Task.Factory.StartNew (
		() => GetAnswerToLifeUniverseAndEverything());
		
	answer.Dump();
}

int GetAnswerToLifeUniverseAndEverything ()
{
	return Enumerable.Range (2, 10000000)
		.AsParallel ()
		.Count (n => Enumerable.Range (2,
						(int)Math.Sqrt (n)).All (i => n % i > 0))
		/ 15823;
}