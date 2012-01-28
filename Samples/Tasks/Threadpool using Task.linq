<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task.Factory.StartNew (() => Console.WriteLine ("x"));

//This is to keep the main thread alive
Thread.Sleep(100);