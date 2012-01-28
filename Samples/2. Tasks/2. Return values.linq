<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task<int> task = Task.Factory.StartNew (
		() => GetPrimes()
	);		
	int result = task.Result;
	result.Dump();
}

int GetPrimes()
{
	var query =
		from n in Enumerable.Range (3, 5000000).AsParallel()
		where Enumerable.Range (2, (int) Math.Sqrt (n)).All (i => n % i > 0)
		select n;		

	return query.Count();
}