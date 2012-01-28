<Query Kind="Program" />

void Main()
{
	System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("es-MX");
	System.Threading.Thread.CurrentThread.CurrentCulture = ci;
}

// Define other methods and classes here
