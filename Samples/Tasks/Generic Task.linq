<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// Start the task executing:
{
	Task<string> task = Task.Factory.StartNew<string>
	( () => 
	{
		using (var wc = new System.Net.WebClient())
		return wc.DownloadString ("http://www.linqpad.net");
	});
	
	// When we need the task's return value, we query its Result property:
	// If it's still executing, the current thread will now block (wait)
	// until the task finishes:
	task.Result.Dump();
}