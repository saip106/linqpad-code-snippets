<Query Kind="Program" />

void Main()
{
	//Overload resolution is done first and only then are the constraints checked
	Foo(new Giraffe());
}

class Animal { }
class Mammal : Animal { }
class Giraffe : Mammal { }
class Reptile : Animal { }
static void Foo1<T>(T t) where T : Reptile { }
static void Foo1(Animal animal) { }
