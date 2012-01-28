<Query Kind="Program">
  <Reference Relative="..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{
	var task = DownloadAsync();
	"Main thread".Dump();
	task.Result.Dump();
}

public async Task<int> DownloadAsync()
{
	"Started Async method".Dump();
	
	var t1 = TaskEx.Run(() => 
	{
		"Inside T1".Dump();
		for (int i = 0; i < 1000000000; i++);
		return "test1";
	});
	await t1;	
	"Started awaiting t1".Dump();
	
	var t2 = TaskEx.Run(() => 
	{
		"Inside T2".Dump();
		for (int i = 0; i < 1000000000; i++);
		return "test2";
	});
	await t2;	
	"Started awaiting t2".Dump();
	
	return t1.Result.Length + t2.Result.Length;
}