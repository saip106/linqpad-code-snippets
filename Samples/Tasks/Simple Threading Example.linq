<Query Kind="Statements" />

var thread = new Thread (() => 
{
	for (int i = 0; i < 100; i++)
	{
		Console.WriteLine (Thread.CurrentThread.Name + " " + i);
		
	}
});
thread.Name = "My Thread";

thread.Start();
for (int i = 0; i < 100; i++)
{
	Console.WriteLine (Thread.CurrentThread.Name + " " + i);
}

