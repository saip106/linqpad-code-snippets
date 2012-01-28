<Query Kind="Program" />

void Main()
{
	Object a = 1; // Boxing
	Object b = a; // referencing the pointer on stack to both objects on heap
	a = 2; // Boxing
	
	("b = " + b).Dump();
}

// Define other methods and classes here
