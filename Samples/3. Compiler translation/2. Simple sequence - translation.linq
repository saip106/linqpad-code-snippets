<Query Kind="Program">
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var sm = new StateMachine(this);
	sm.MoveNext();
}

class StateMachine
{
	UserQuery _host;
	int _state;
	Task<string> _taskA, _taskB, _taskC;
	string s1, s2, s3;
	
	public StateMachine (UserQuery host) { _host = host; }

	public void MoveNext()
	{
		switch (_state++)
		{
			case 0:
				_taskA = _host.A();
				_taskA.ContinueWith (ant => MoveNext());
				return;
			case 1:
				s1 = _taskA.Result;
				_taskB = _host.B();
				_taskB.ContinueWith (ant => MoveNext());
				return;
			case 2:
				s2 = _taskB.Result;
				_taskC = _host.C();
				_taskC.ContinueWith (ant => MoveNext());
				return;
			case 3:
				s3 = _taskC.Result;				
				Console.WriteLine (s1 + s2 + s3);
				return;
		}
	}
}

Task<string> A() { return TaskEx.Delay (1000).ContinueWith (ant => "A"); }
Task<string> B() { return TaskEx.Delay (1000).ContinueWith (ant => "B"); }
Task<string> C() { return TaskEx.Delay (1000).ContinueWith (ant => "C"); }