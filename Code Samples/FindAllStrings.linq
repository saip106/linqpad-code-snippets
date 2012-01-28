<Query Kind="Program">
  <Connection>
    <ID>eac29d49-5364-4451-bba1-ba37ee86085f</ID>
    <Server>.</Server>
    <Driver></Driver>
    <ShowServer>true</ShowServer>
    <Database>LoadTest2010</Database>
  </Connection>
</Query>

void Main()
{
	var rootPath = @"C:\Projects\omnyx\main\raymondloewy";
	var filePaths = Directory.GetFiles(rootPath, "*.cs", SearchOption.AllDirectories);

	foreach (var filePath in filePaths.Take(10))
	{
		if (filePath.Contains("AssemblyInfo.cs"))
		{
			continue;
		}
	
		StreamReader sr = new StreamReader(filePath);
	
		var badScenarios = new List<string>();
		sr.Lines().ToList().ForEach(line => 
		{
			if(line.Contains("\""))
			{
				if (line.Contains("Logger") || line.Contains("_logger") || line.Contains(".Debug(") || line.Contains(".Detail(") || line.Contains(".Info("))
				{
					
				}
				else
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