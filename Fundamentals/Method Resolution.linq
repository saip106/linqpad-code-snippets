<Query Kind="Program" />

void Main()
{
	int? test = null;
	Foo(test);	
}

// Constraint won't be considered when building the candidate set
void Foo<T>(T value) where T : struct {Console.WriteLine ("T is struct");}

// The constraint *we express* won't be considered when building the candidate
// set, but then constraint on Nullable<T> will
void Foo<T>(Nullable<T> value) where T : struct {Console.WriteLine ("T is Nullable<struct>");}





