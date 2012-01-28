<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>C:\source\Mandelbrot\bin\Release\Mandelbrot.dll</Reference>
  <Namespace>System.Windows</Namespace>
</Query>

var frame = new Mandelbrot.Frame (
	new System.Windows.Rect (-2, -1.2, 2.5, 2.4), 800, 600, renderNow:true);

frame.GetImage().Dump();