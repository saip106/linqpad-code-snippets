<Query Kind="Program" />

void Main()
{
	//Example 1

	//Two anonymous types declared in the same assembly are unified into the same object.
	//They need exact same member types, names in exact same order
	var anon1 = new { X = 1 };
	var anon2 = new { X = 2 };
	anon2 = anon1; 
	
	anon2.X.Dump();
	
	
	//Example 2
	D.M();
}

class C
{
	public static object Anon1() { return new { X = 1 }; }
}

class D
{
	public static void M()
	{
		// True:
		Console.WriteLine(C.Anon1().GetType() == (new { X = 2 }).GetType());
	}
}
