<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\wpf\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>C:\source\Mandelbrot\bin\Release\Mandelbrot.dll</Reference>
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
  <Namespace>System.Windows.Controls.Primitives</Namespace>
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Windows.Input</Namespace>
  <Namespace>System.Windows.Media</Namespace>
  <Namespace>System.Windows.Threading</Namespace>
  <Namespace>System.Windows.Media.Imaging</Namespace>
</Query>

Image image = new Image { Stretch = Stretch.None };

PanelManager.DisplayWpfElement (image);

var files = new DirectoryInfo (@"c:\Mandelbrot")
	.GetFiles ("*.png")
	.OrderBy (f => f.Name)
	.Select (f => f.FullName);
			
foreach (string file in files)
{
	image.Source = new BitmapImage (new Uri (file));
	await TaskEx.Delay (50);
}