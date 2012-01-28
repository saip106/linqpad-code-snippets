<Query Kind="Statements">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

string[] uris =
{
	"http://linqpad.net",
	"http://linqpad.net/downloadglyph.png",
	"http://linqpad.net/linqpadscreen.png",
	"http://linqpad.net/linqpadmed.png",
};

int totalLength = 0;
foreach (string uri in uris)
{
	string content = new WebClient().DownloadString (new Uri (uri));
	content.Length.Dump (uri);
	totalLength += content.Length;
}
totalLength.Dump ("TOTAL");