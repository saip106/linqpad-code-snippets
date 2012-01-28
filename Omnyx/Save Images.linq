<Query Kind="Program" />

void Main()
{
	var bytes = new byte[300];
	
	for (int i = 0; i < bytes.Length; i += 3)
	{
	//i.Dump();
		if (i<150)
		{
			bytes[i] = 50;
			bytes[i + 1] = 50;
			bytes[i + 2] = 50;
		}
		else
		{
			bytes[i] = 230;
			bytes[i + 1] = 230;
			bytes[i + 2] = 230;
		}
	}
	File.WriteAllBytes(@"C:\Users\sai.gudigundla\Desktop\test1.raw", bytes);
}

// Define other methods and classes here
