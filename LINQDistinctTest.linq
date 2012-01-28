<Query Kind="Program" />

void Main()
{
	List<Foo> foos = new List<Foo>();
	foos.Add(new Foo { FooString="1", BarString="A"});
	foos.Add(new Foo { FooString="1", BarString="B"});
	foos.Add(new Foo { FooString="2", BarString="C"});
	foos.Add(new Foo { FooString="3", BarString="A"});
	foos.Add(new Foo { FooString="3", BarString="B"});
	foos.Add(new Foo { FooString="2", BarString="C"});
	
	foos.Select (f => f.FooString).Distinct().Dump();
}

// Define other methods and classes here
class Foo
{
	public string FooString { get; set; }
	public string BarString { get; set; }
}