<Query Kind="Program" />

void Main()
{
	Elvis.Instance.GetBeltsize().Dump();
}

class Elvis
{
	public static readonly Elvis Instance = new Elvis();
	
	private readonly int beltsize;
	public int GetBeltsize() 
	{
		return beltsize;
	}
	
	private static readonly int CurrentYear = DateTime.Now.Year;
	
	private Elvis()
	{
		beltsize = CurrentYear - 1930;
	}
}

//Static fields are initialized from top to bottom
//Since the first one calls the constructor it used the CurrentYear field even before it's initialized hence -1930
