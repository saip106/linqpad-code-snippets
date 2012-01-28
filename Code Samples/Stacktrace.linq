<Query Kind="Statements" />

var stackTrace = new StackTrace();

foreach (var frame in stackTrace.GetFrames())
{
	frame.GetMethod().Dump();
}