<Query Kind="Program" />

void Main()
{
	var fileName = @"C:\Projects\omnyxsource\main\raymondloewy\testautomation\acceptancetesting\omnyx.acceptance.tests\aplis\features\AplisDictionaryMapping\AplisPersonDictionaryMapping.feature";
	StreamReader sr = new StreamReader(fileName);
	
	var tagLines = new List<string>();
	string previousLine = null;
	sr.Lines().ToList().ForEach(line => 
	{
		if((line.Contains("Scenario:") || line.Contains("Scenario Outline")) && previousLine != null)
		{
			line.Dump();
			tagLines.Add(previousLine);
		}
		
		previousLine = line;
	});
	tagLines.Dump();
	
//	var lines = File.ReadAllLines(fileName);	
//	GetTheLineAboveScenarioLine(lines).Dump();
}

public IEnumerable<string> GetTheLineAboveScenarioLine(IEnumerable<string> lines)
{
	var tagLines = new List<string>();

	string previousLine = null;
	foreach (var line in lines)
	{		
		if((line.Contains("Scenario:") || line.Contains("Scenario Outline")) && previousLine != null)
		{
			line.Dump();
			tagLines.Add(previousLine);
		}
		
		previousLine = line;
		continue;	
	}
	
	return tagLines;
}

public static class StreamReaderSequence
{
	public static IEnumerable<string> Lines(this StreamReader source)
	{
	  String line;

	  if (source == null)
		  throw new ArgumentNullException("source");
	  while ((line = source.ReadLine()) != null)
	  {
		yield return line;
	  }
	}
}