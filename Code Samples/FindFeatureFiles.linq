<Query Kind="Program" />

void Main()
{
	var rootPath = @"C:\Projects\omnyxsource\main\raymondloewy\testautomation\acceptancetesting\omnyx.acceptance.tests";
	var filePaths = Directory.GetFiles(rootPath, "*.feature", SearchOption.AllDirectories);
	filePaths.Dump();
}

// Define other methods and classes here
