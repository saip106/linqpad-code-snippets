<Query Kind="Program" />

void Main()
{
	int[] data = {1,2,3,1,2,1};
	var list = new List<IEnumerable<int>>();
	
	foreach (var i in data.Distinct())
	{
		list.Add(from k in data where k == i select k);
	}
	
	foreach (var m in list)
	{
		foreach (var n in m)
		{
			n.Dump();
		}
	}
}

//The fix is store i in j

//Never use mutable data in LINQ queries as LINQ queries are lazy
//For and foreach loop indices are mutable, just not by you

// Define other methods and classes here
