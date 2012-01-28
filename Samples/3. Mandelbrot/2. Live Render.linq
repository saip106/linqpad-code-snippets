<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference Relative="..\..\..\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll">&lt;Personal&gt;\Microsoft Visual Studio Async CTP\Samples\AsyncCtpLibrary.dll</Reference>
  <Reference>C:\source\Mandelbrot\bin\Release\Mandelbrot.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
  <Namespace>System.Drawing</Namespace>
</Query>

System.Windows.Rect setBounds = new System.Windows.Rect (-2, -1.2, 2.5, 2.4);
Mandelbrot.Frame frame;
Task renderTask;

PictureBox pic = new PictureBox();
System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 100 };

void Main()
{
	timer.Tick += delegate
	{
		if (pic.Image != null) pic.Image.Dispose();
		pic.Image = frame.GetImage();
		if (renderTask.IsCompleted) timer.Stop();
	};

	pic.SizeChanged += (sender, args) => RenderToScreen();
	pic.MouseDown += (sender, args) => Zoom (args.Location);
	pic.Disposed += (sender, args) => { pic.Image.Dispose(); timer.Dispose(); };
	
	PanelManager.DisplayControl (pic, "Mandelbrot");
}

void RenderToScreen ()
{	
	frame = new Mandelbrot.Frame (setBounds, pic.Width, pic.Height);
	renderTask = Task.Factory.StartNew (frame.Render);
	timer.Start();
}

void Zoom (Point centrePixel)
{
	if (timer.Enabled) return;	
	setBounds = frame.GetZoomRect (centrePixel.X, centrePixel.Y);
	setBounds.Dump();
	RenderToScreen();
}