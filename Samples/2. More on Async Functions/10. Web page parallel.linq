<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	int siteSize = await GetSiteSize (new Uri ("http://stackoverflow.com"));
	Console.WriteLine (siteSize);
}

async Task<int> GetSiteSize (Uri uri)
{
	string html = await new WebClient().DownloadStringTaskAsync (uri);

	var otherFiles =
		from Match m in SrcMatch.Matches (html)
		select m.Groups[1].Value;
		
	var otherFileLengths = 
		from otherPage in otherFiles.Distinct()
		select new WebClient().DownloadDataTaskAsync (
								new Uri (uri, otherPage));
	
	var fileContents = await TaskEx.WhenAll (otherFileLengths);
	return html.Length + fileContents.Sum (fc => fc.Length);
}

Regex SrcMatch = new Regex (@"src\s*=\s*['""](.*?)['""]", RegexOptions.IgnoreCase);