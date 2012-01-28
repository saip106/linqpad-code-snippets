<Query Kind="Program" />

void Main()
{
	var d = new D();
	d.Func();

}

public abstract class B
{
	public abstract void Func();
	protected B() 
	{
		Console.WriteLine("In B.B()");
		Func(); 
	}
}

public class D : B
{
	private readonly string msg = "original value";
	public D()
	{
		msg = "I've been set again";
	}
	public override void Func()
	{
		Console.WriteLine("In D.Func(). Message is \'{0}\'", msg);
	}
}
