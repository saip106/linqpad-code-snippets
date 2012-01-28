<Query Kind="Program" />

void Main()
{
	var rootPath = @"C:\Projects\omnyxsource\main\raymondloewy\testautomation\acceptancetesting\omnyx.acceptance.tests";
	var filePaths = Directory.GetFiles(rootPath, "*.feature", SearchOption.AllDirectories);

	foreach (var filePath in filePaths)
	{
		StreamReader sr = new StreamReader(filePath);
	
		var badScenarios = new List<string>();
		sr.Lines().ToList().ForEach(line => 
		{
			if(line.Contains("Scenario:") || line.Contains("Scenario Outline"))
			{
				if (!line.Contains("[US") && !line.Contains("[DE"))				
				{				
				    badScenarios.Add(line);
				}
			}
		});
		if (badScenarios.Count > 0)
		{
			filePath.Dump();
		    badScenarios.Dump();	
		}		
	}
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