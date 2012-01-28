<Query Kind="Program" />

void Main()
{
	Lazy.PI.Dump();
}

class Lazy
{
	public static float PI;
	public static bool initialized = doInit();
	static bool doInit()
	{
		if (!initialized)
		{
			Thread t = new Thread(new ThreadStart(DoInit));
			t.Start();
			t.Join();
		}
		return true;
	}
	
	public static void DoInit()
	{
		PI = 3.14f;
	}
}

//Example of lock free deadlock
//Do initialization on the main thread
