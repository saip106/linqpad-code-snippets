<Query Kind="Program" />

void Main()
{
	FuncFruit f1 = MethodReturningFruit;
	FuncBanana f2 = MethodReturningBanana;
	
	//This isn't conversion of the original delete
	//This creates a new Delegate
	FuncFruit f3 = new FuncFruit(f2);
	
	//Covariance is when we are getting something OUT
	//Contravariance is when we are putting something in
}

delegate Fruit FuncFruit();
delegate void ActionBanana(Banana x);
delegate Banana FuncBanana();
delegate void ActionFruit(Fruit x);

Fruit MethodReturningFruit() {return null;}
void MethodTakingFruit(Fruit x) {}
Banana MethodReturningBanana() {return null;}
void MethodTakingBanana(Banana x){}

class Fruit { }
class Apple : Fruit { }
class Banana : Fruit { }
