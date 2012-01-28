<Query Kind="Program">
  <Reference>&lt;ProgramFiles&gt;\Inner Harbor Software\HL7Spy\Core.dll</Reference>
  <Namespace>Core.Hl7</Namespace>
</Query>

void Main()
{
	Hl7Message message = new Hl7Message(string.Empty);
	
	PID pidSegment = new PID();
	pidSegment.BirthPlace_23.Value = "Hyderabad";
	pidSegment.CountyCode_12.Value = "USA";
	pidSegment.AdministrativeSex_08.Value = "MALE";
	pidSegment.AlternatePatientID_PID_04.Value = "Alt_PID";
	pidSegment.BirthOrder_25.Value = "";
		
	message.Append(pidSegment);
	message.Append(new MSH());
	
	message.RawMessage.Dump();	
}
