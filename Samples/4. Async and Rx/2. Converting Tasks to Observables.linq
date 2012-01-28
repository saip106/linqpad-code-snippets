<Query Kind="Statements">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Reference Relative="System.Reactive.dll">&lt;Personal&gt;\LINQPad Queries\TechEd Async\4. Async and Rx\System.Reactive.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

string[] uris =
{
	"http://linqpad.net",
	"http://linqpad.net/downloadglyph.png",
	"http://linqpad.net/linqpadscreen.png",
	"http://linqpad.net/linqpadmed.png",
};

var query =
	from uri in uris.ToObservable()
	from html in new WebClient().DownloadStringTaskAsync (uri).ToObservable()
	select html.Length;

IObservable<int> result = query.Sum();

int intResult = await result;			// "Unwrap" the observable result.

intResult.Dump();