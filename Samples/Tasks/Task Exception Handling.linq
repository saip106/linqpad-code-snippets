<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var task = Task.Factory.StartNew (() => 
{
	throw new Exception("Test Exception");
});

//If we don't do this the exception will not be thrown to this thread
task.Wait();

