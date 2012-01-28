<Query Kind="Program" />

void Main()
{
	var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

	nums.Select (n => (double)n).Dump();
	
	var doubles = from double n in nums select n;
	foreach (var d2 in doubles)
	{
		Console.WriteLine(d2);
	}	
	
	/*
	Version that works !!!
	
	var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	var doubles = nums.Convert<double>().Select(d => d);
	foreach (var d2 in doubles)
		{ 
			Console.WriteLine(d2);
		}
	*/
}

public static class ExtensionsThatWork
{
	public static IEnumerable<TResult> Convert<TResult>
		(this System.Collections.IEnumerable sequence)
	{
		foreach (object o in sequence)
		{
			dynamic item = o;
			yield return (TResult)item;
		}
	}
}

