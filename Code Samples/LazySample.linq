<Query Kind="Program" />

void Main()
{
	var query = new Lazy<string>( () => GetString());
	query.IsValueCreated.Dump();
	Console.WriteLine(query.Value);
	query.IsValueCreated.Dump();	
}

// Define other methods and classes here
string GetString(){
	return "Hello world";
}
