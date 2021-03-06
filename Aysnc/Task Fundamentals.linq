<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var task1 = Task.Factory.StartNew(() => 
	{
		//some code here	
	});
	task1.ContinueWith(
	t => 
	{
		//Do something when task1 is done
	}, TaskScheduler.Default);
	
	//TaskScheduler.Default schedules a thread on the thread pool
	
	//To do something on UI thread
	task1.ContinueWith(
	t =>
	{
		//Some UI code
	}, TaskScheduler.FromCurrentSynchronizationContext());
}

// Define other methods and classes here
