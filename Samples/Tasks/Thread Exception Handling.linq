<Query Kind="Statements" />

try
{
	new Thread (() => 
	{
		throw new Exception();
	}).Start();
}
catch (Exception ex)
{
	// We'll never get here!
	Console.WriteLine ("Exception!");
}

for (int i = 0; i < 100; i++)
{
	Console.WriteLine (i);
}