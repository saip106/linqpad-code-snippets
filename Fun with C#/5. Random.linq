<Query Kind="Program" />

void Main()
{
	var set = new HashSet<int>();
	var random = new Random();
	
	for (int i = 0; i < 100; i++)
	{
		set.Add(new Random().Next());
	}
	
	set.Count ().Dump();
}

// Define other methods and classes here
