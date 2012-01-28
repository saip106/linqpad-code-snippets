<Query Kind="Program">
  <Reference>&lt;ProgramFiles&gt;\Inner Harbor Software\HL7Spy\HL7Spy.Core.dll</Reference>
  <Namespace>System.Net.Sockets</Namespace>
</Query>

void Main()
{
	string startFrame = Convert.ToChar(11).ToString();
	string basehl7Message = @"MSH|^~\&|cop|APLab1|Omnyx|APLab1|201008031330||OML^O21|756777657567|P|2.5.1
PID|1234567891||1110080222^^^dclient_cop371^MRN||SudheerTesting^PartType_1^M^Jr||197006041330|M||
PV1||I|||||||||||||||||680906^^^dclient_cop371
ORC|NW||||||||201008031330|||dperson_cop22^SMITH^MARY^^^DR^MD
OBR|||HL7-99999|S-R||201008031330|||||||Something happened|||||DERM||||||||||||||dperson_cop22&HO&JONHAN&&&DR&MD
TQ1|||||||||dspecprty_cop37
OBX||TX|FD||This is CH1
OBX||TX|FD||This is CH2
OBX||TX|FD||This is CH3
OBX||TX|CH||This is CH4
OBX||TX|CH||This is CH5";
	string endFrame = Convert.ToChar(28).ToString() + Convert.ToChar(13).ToString();
	
	string hl7Message = startFrame + basehl7Message + endFrame;
	
    TcpClient  client = new TcpClient();

    client.Connect("localhost", 6661);
	
	using(NetworkStream clientStream = client.GetStream())
   {
		ASCIIEncoding encoder = new ASCIIEncoding();
		byte[] buffer = encoder.GetBytes(hl7Message);
		
		clientStream.Write(buffer, 0 , buffer.Length);
		clientStream.Flush();
   }
}