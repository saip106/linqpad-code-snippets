<Query Kind="Program">
  <Connection>
    <ID>eac29d49-5364-4451-bba1-ba37ee86085f</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Driver></Driver>
    <Database>msdb</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Reference>&lt;ProgramFiles&gt;\Inner Harbor Software\HL7Spy\Core.dll</Reference>
  <Namespace>Core.Hl7</Namespace>
</Query>

void Main()
{
	Hl7Message message = new Hl7Message(string.Empty, true);

	MSH mshSegment = new MSH();	
	mshSegment.EncodingCharacters_02.Value = @"^~\&";
	mshSegment.SendingApplication_03.Value = "ADM";
	mshSegment.SendingFacility_04.Value = "cop";
	mshSegment.ReceivingApplication_05.Value = "ALL";
	mshSegment.ReceivingFacility_06.Value = "omnyx";
	mshSegment.DateTimeOfMessage_07.Value = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + 
											DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
	mshSegment.Security_08.Value = string.Empty;
	mshSegment.MessageType_09.Value = "ADT^A08";
	mshSegment.MessageControlID_10.Value = "20090101010";
	mshSegment.ProcessingID_11.Value = "P";
	mshSegment.VersionID_12.Value = "2.1";
	
	PID pidSegment = new PID();
	pidSegment.SetID_PID_01.Value = "1";
	
	//FieldNodeList<CX> list = new FieldNodeList<CX>(pidSegment, 3);
	//pidSegment.PatientIdentifierList_03
	
	
	message.Append(mshSegment);
	message.Append(pidSegment);
	
	message.RawMessage.Dump();
}

// Define other methods and classes here

//MSH|^~\&|ADM|cop|ALL|omnyx|20090101010000||ADT^A08|20090101010|P|2.1
//PID|1||717170602^^^dclient_cop234^MR~100-45-1122^^^dclient_cop234^SS||Mouse^Mickey^M^^^MME||2005-12-05T00:00:00|M||drace_cop12|7136 GARDEN HWY^SACRAMENTO^SACRAMENTO^CA^94254^USA|||||||242-82-6897|242-82-6897
//PV1|1|I|P148^R6^B2|E|||674-29-9786^WANSER^JEREMIAH^ETHAN^MD^DR|479-38-3053^LEIGERS^MATHEW^DAMIEN^MD^DR||||||2||||IN||||||||||||||||||||||||||20090101125500
//NK1|1|SEIBERT^FAUSTO^SPENCER^^^CPNP|FA
//IN1|1|UNIT HLTH||||||||||||||SEIBERT^GALE^MATTHEW^^^MME|SELF