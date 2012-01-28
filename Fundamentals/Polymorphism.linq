<Query Kind="Program">
  <Reference>C:\Projects\ThirdParty\NUnit\nunit.framework.dll</Reference>
  <Namespace>NUnit.Framework</Namespace>
</Query>

void Main()
{
	Baz baz = new Baz();
	Foo foo = new Foo();

	// overloading - parameter type is known during compile time
	Assert.AreEqual("zap object", baz.Zap("hello"));
	Assert.AreEqual("zap foo", baz.Zap(foo));


	// virtual call - single dispatch. Baz is used.
	Zapper zapper = baz;
	Assert.AreEqual("zap object", zapper.Zap("hello"));
	Assert.AreEqual("zap foo", zapper.Zap(foo));


	// C# has doesn't support multiple dispatch so it doesn't
	// know that oFoo is actually of type Foo.
	//
	// In languages with multiple dispatch, the type of oFoo will 
	// also be used in runtime so Baz.Zap(Foo) will be called
	// instead of Baz.Zap(object)
	object oFoo = foo;
	Assert.AreEqual("zap object", zapper.Zap(oFoo));
	
	
}

public class Zapper
{
	public virtual string Zap(object o) { return "generic zapper" ; }
	public virtual string Zap(Foo f) { return "generic zapper"; }
}

public class Baz : Zapper
{
	public override string Zap(object o) { return "zap object"; }
	public override string Zap(Foo f) { return "zap foo"; }
}

public class Foo { }

// Define other methods and classes here
