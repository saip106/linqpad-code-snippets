<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
	Console.WriteLine (InputLanguage.InstalledInputLanguages.Count); 
	var current  = InputLanguage.InstalledInputLanguages.IndexOf(InputLanguage.CurrentInputLanguage);
	Console.WriteLine (current);
	Console.WriteLine (InputLanguage.InstalledInputLanguages[1].LayoutName); 
	InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
}

// Define other methods and classes here
