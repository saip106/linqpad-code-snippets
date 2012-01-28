<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	string result = await ABC();
	Console.WriteLine (result);
}

async Task<string> ABC() 
{
	string s1 = await A();
	string s2 = await B();
	string s3 = await C();
		
	return s1 + s2 + s3;
}

async Task<string> A() { await TaskEx.Delay (1000); return "A"; }
async Task<string> B() { await TaskEx.Delay (1000); return "B"; }
async Task<string> C() { await TaskEx.Delay (1000); return "C"; }