<Query Kind="Statements">
  <Connection>
    <ID>eac29d49-5364-4451-bba1-ba37ee86085f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Driver></Driver>
    <Database>OmnyxWorkflowDev</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var query = from s in Stains
			where s.Name.Contains("11q,")
			select s;
			
var stain = query.FirstOrDefault (); 
if (stain != null)
{
	Stains.DeleteOnSubmit(stain);
}


var aplisStain = AplisStainTypes.Where (ast => ast.Name.Contains("11q,")).FirstOrDefault ();
aplisStain.MappedTo = null;

SubmitChanges();
query.Dump();