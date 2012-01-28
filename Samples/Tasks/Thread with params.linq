<Query Kind="Statements" />

Thread t = new Thread(@object => 
{
	Console.WriteLine (@object);
});
t.Start("Hello from t!");
t.IsBackground = false;

for (int i = 0; i < 100; i++)
{
	Console.WriteLine ("blah");
}