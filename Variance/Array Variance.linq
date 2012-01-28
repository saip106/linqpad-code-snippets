<Query Kind="Program" />

void Main()
{
	Banana[] bananas = { new Banana(), new Banana()};
	Fruit[] fruits = bananas;
	
	//Fine
	fruits[0] = new Banana();
	
	//This will fail during runtime
	fruits[0] = new Apple();
	
	//This will not fail at compile time. This is taken from Java
	//With Generics they wanted to make this safe
}

class Fruit { }
class Apple : Fruit { }
class Banana : Fruit { }
