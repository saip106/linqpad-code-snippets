<Query Kind="Program" />

void Main()
{
	var derived = new Derived();
}

//Singleton
class Foo
{
	public Foo()
	{
		Console.WriteLine ("Foo");
	}
}

class Bar
{
	public Bar()
	{
		Console.WriteLine ("Bar");
	}
}

class Base
{
	private Foo myFoo = new Foo();
	
	public Base()
	{
		Console.WriteLine ("Base");
	}
}

class Derived : Base
{
	private Bar myBar = new Bar();
	
	public Derived() : base()
	{
		Console.WriteLine ("Derived");
	}
}

//Base, Derived
//Foo, Bar, Foo, Base, Derived