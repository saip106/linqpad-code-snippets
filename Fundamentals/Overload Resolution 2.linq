<Query Kind="Program" />

void Main()
{
	//Sample 1
	C c = new C();
	//c.M("hello"); //This line fails 
	//Here again best overload is determined based on method parameters and then and only then is the static constratint checked
	
	//Sample 2
	new B().N(); // This is also referred to as the Color Color problem
	
	//Sample 3
	M(null);
	//When picking the compiler tried to pick more specific type
	//All attays are objects but not all objects are arrays hence it picks the array overload
}

class C
{
	public static void M(string x)
	{
		System.Console.WriteLine("static M(string)");
	}
	public void M(object s)
	{
		System.Console.WriteLine("M(object)");
	} 
}

class B
{
  public C C = new C();
  public void N()
  {
	  C.M("hello");
  }
}

static void M(object[] array) {Console.WriteLine ("object array as parameter");}
static void M(object obj) { Console.WriteLine ("object as parameter"); }



