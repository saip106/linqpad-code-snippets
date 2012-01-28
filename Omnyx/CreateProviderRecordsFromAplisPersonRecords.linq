<Query Kind="Statements">
  <Connection>
    <ID>dc10ba94-3d07-40a0-8264-b7abbf02e30f</ID>
    <Persist>true</Persist>
    <Server>pgh-stage-sql\qa5</Server>
    <Database>OmnyxDCFWorkflowQA5</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var query = (from p in AplisPersons
			select p);
query.Dump();
Providers.Count ().Dump();
			
foreach (var element in query)
{
	try
	{	        
		Providers.InsertOnSubmit(new Provider{
			 PracticeName = element.DisplayName,
			 Person = new Person{
			 	 FirstName = element.FirstName,
				 LastName = element.LastName,	
				 MobilePhone = element.MobilePhone,
				 Email = element.Email,	
				 DateCreated = DateTime.Now,
				 DateUpdated = DateTime.Now,
				 SuffixID = 1,
			 },		 
		});
		SubmitChanges();
	}
	catch (Exception ex)
	{
		Console.WriteLine (element.FirstName);		
	}
}

Providers.Count ().Dump();