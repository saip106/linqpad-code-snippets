<Query Kind="Statements" />

ThreadPool.QueueUserWorkItem (obj => { Console.WriteLine ("test");});
ThreadPool.QueueUserWorkItem (obj => { Console.WriteLine ("test {0}", obj);}, 123);

//To keep the main thread alive
Thread.Sleep(100);