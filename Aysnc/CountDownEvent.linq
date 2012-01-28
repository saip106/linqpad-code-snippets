<Query Kind="Program" />

void Main()
{
	var count = 100000000;
	using(var countDownEvent = new CountdownEvent(count))
	{
		for (int i = 0; i < count; i++)
		{
			countDownEvent.Signal();
			
		}
		countDownEvent.Wait();
		"Done".Dump();
	}
}

// Define other methods and classes here
