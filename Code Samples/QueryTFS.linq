<Query Kind="Program">
  <Reference>&lt;ProgramFiles&gt;\Microsoft Visual Studio 10.0\Common7\IDE\ReferenceAssemblies\v2.0\Microsoft.TeamFoundation.Common.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Visual Studio 10.0\Common7\IDE\ReferenceAssemblies\v2.0\Microsoft.TeamFoundation.Client.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Visual Studio 10.0\Common7\IDE\ReferenceAssemblies\v2.0\Microsoft.TeamFoundation.VersionControl.Common.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Microsoft Visual Studio 10.0\Common7\IDE\ReferenceAssemblies\v2.0\Microsoft.TeamFoundation.VersionControl.Client.dll</Reference>
  <Namespace>Microsoft.TeamFoundation.Client</Namespace>
</Query>

void Main()
{
	var tfs = TfsTeamProjectCollectionFactory
				.GetTeamProjectCollection(new Uri("http://omnyxtfs01:8080/"));
	tfs.EnsureAuthenticated();
	tfs.Uri.Dump();
	
}

// Define other methods and classes here
