<Query Kind="Program" />

void Main()
{
	var numbers = Enumerable.Range(1, 1000000);
	
	//Using to array the results will be ordered
	//Not using ToArray() will be a bit faster but results will not be ordered
	MyTimer.Measure("Parallel with ToArray", () => 
	{
		numbers.AsParallel().Where(n => IsPrime(n)).ToArray();
	});
	
	MyTimer.Measure("Parallel with no ToArray", () => 
	{
		numbers.AsParallel().Where(n => IsPrime(n)).Count();
	});
	
	MyTimer.Measure("No Parallel", () => 
	{
		numbers.Where(n => IsPrime(n)).ToArray();
	});
	
	MyTimer.Measure("No Parallel", () => 
	{
		using(var countDownEvent = new CountdownEvent(numbers.Count()))
		{
			foreach (var number in numbers)
			{
				ThreadPool.QueueUserWorkItem(callback =>
				{
					IsPrime(number);
					countDownEvent.Signal();
				}, null);
			}					
			countDownEvent.Wait();			
		}
	});
}

public static bool IsPrime(int candidate)
{
// Test whether the parameter is a prime number.
if ((candidate & 1) == 0)
{
    if (candidate == 2)
    {
	return true;
    }
    else
    {
	return false;
    }
}
// Note:
// ... This version was changed to test the square.
// ... Original version tested against the square root.
// ... Also we exclude 1 at the very end.
for (int i = 3; (i * i) <= candidate; i += 2)
{
    if (candidate % i == 0)
    {
		return false;
    }
}
return candidate != 1;
}

class MyTimer
{
	public static void Measure(string eventName, Action action)
	{
		var stopwatch = new Stopwatch();
		stopwatch.Start();
		action();
		stopwatch.Stop();
		(eventName + ": " + stopwatch.ElapsedMilliseconds).Dump();
		stopwatch.Reset();
	}
}
