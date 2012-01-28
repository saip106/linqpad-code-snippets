<Query Kind="Program" />

void Main()
{
	Banana banana = new Banana();
	
	//Implicit reference conversion
	Fruit fruit = banana;
	
	//Doing this will cause next line to fail
	fruit = new Apple();
	
	//Explicit reference conversion
	Banana b1 = (Banana)fruit;
	
	//Compiler knows this will fail
	//Apple b2 = (Banana)banana;
}

class Fruit { }
class Apple : Fruit { }
class Banana : Fruit { }