<Query Kind="Program" />

void Main()
{	
	List<int> values = new List<int> { 1, 2 };
		using (var iterator = values.GetEnumerator())
		{
			iterator.GetType().Dump();
			ShowNext(iterator);
			ShowNext(iterator);
			ShowNext(iterator);
		} 
}

static void ShowNext(IEnumerator<int> iterator)
	{
		if (iterator.MoveNext())
		{
			Console.WriteLine(iterator.Current);
		}
		else
		{
			Console.WriteLine("Done");
		}
	} 
