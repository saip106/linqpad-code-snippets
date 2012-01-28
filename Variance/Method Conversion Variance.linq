<Query Kind="Program" />

void Main()
{
	FuncFruit f1 = new FuncFruit(MethodReturningFruit);
	FuncFruit f2 = new FuncFruit(MethodReturningBanana); //Covariance
	
	ActionBanana a1 = MethodTakingBanana;
	ActionBanana a2 = MethodTakingFruit;
}

delegate Fruit FuncFruit();
delegate void ActionBanana(Banana x);

Fruit MethodReturningFruit() {return null;}
void MethodTakingFruit(Fruit x) {}
Banana MethodReturningBanana() {return null;}
void MethodTakingBanana(Banana x){}

class Fruit { }
class Apple : Fruit { }
class Banana : Fruit { }
