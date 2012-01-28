<Query Kind="Program" />

void Main()
{
	double cash = 5.00;
	double cost = 1.10;
	double change = cash - cost;
	int change_dollars = (int)change;
	int change_cents = (int)(100 * (change - change_dollars));
	
	string.Format("{0}.{1}", change_dollars, change_cents).Dump();
}

//Decimals cannot be represented precisely in binary
//0.9 will be represented as 0.899999999 or 0.90000011111
//Varies from machine to machine (64 bit vs 32 bit)
//The problem starts with cost where 1.10 is stored as 1.099999999

//solution is to use decimals instead of double
//You can also use long and store everything in pennies
