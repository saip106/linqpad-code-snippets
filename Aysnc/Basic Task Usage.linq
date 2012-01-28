<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var source = new CancellationTokenSource();

	var task = Task.Factory.StartNew<string>(() => 
	{
		Thread.Sleep(1000);
		Console.WriteLine ("Hello Task !!!");
		Console.WriteLine (Thread.CurrentThread.ManagedThreadId);
		return "I am done";
	}, source.Token);	
	source.Cancel();
	Console.WriteLine ("I am first");
	Console.WriteLine (Thread.CurrentThread.ManagedThreadId);
	//task.Wait();
	//task.Result.Dump();
}

// Define other methods and classes here