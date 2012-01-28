<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	ABC().ContinueWith (ant => Console.WriteLine (ant.Result));
}

Task<string> ABC()
{
	var sm = new StateMachine(this);
	sm.ABC();
	return sm.Task;
}

class StateMachine
{
	UserQuery _host;
	int _state;
	Task<string> _taskA, _taskB, _taskC;
	string s1, s2, s3;
	TaskCompletionSource<string> _tcs = new TaskCompletionSource<string>();
	public Task<string> Task { get { return _tcs.Task; } }
	
	public StateMachine (UserQuery host) { _host = host; }

	public void ABC()
	{
		try
		{		
			switch (_state++)
			{
				case 0:
					_taskA = _host.A();
					_taskA.ContinueWith (ant => ABC());
					return;
				case 1:
					s1 = _taskA.Result;
					_taskB = _host.B();
					_taskB.ContinueWith (ant => ABC());
					return;
				case 2:
					s2 = _taskB.Result;
					_taskC = _host.C();
					_taskC.ContinueWith (ant => ABC());
					return;
				case 3:
					s3 = _taskC.Result;				
					_tcs.SetResult (s1 + s2 + s3);
					return;
			}
		}
		catch (Exception ex)
		{
			_tcs.SetException (ex);
		}
	}
}

Task<string> A() { return TaskEx.Delay (1000).ContinueWith (ant => "A"); }
Task<string> B() { return TaskEx.Delay (1000).ContinueWith (ant => "B"); }
Task<string> C() { return TaskEx.Delay (1000).ContinueWith (ant => "C"); }