<Query Kind="Statements">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var tcs = new TaskCompletionSource<string>();

new Timer (_ => tcs.SetResult ("Hello, world")).Change (2000, -1);

Task<string> task = tcs.Task;

task.ContinueWith (ant => Console.WriteLine (ant.Result));

