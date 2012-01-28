<Query Kind="Program">
  <Reference>&lt;ProgramFiles&gt;\Inner Harbor Software\HL7Spy\HL7Spy.Core.dll</Reference>
  <Namespace>System.Net.Sockets</Namespace>
</Query>

void Main()
{
	string startFrame = Convert.ToChar(11).ToString();
	string basehl7Message = @"MSH|^~\&|tony|APLab1|Omnyx|APLab1|2010-08-04T08:47:00||OML^O21|756777657567|P|2.5.1PID|||2010080201^^^pmc0401^MRN||JOHN^DOE^M^Jr||1970-06-04T00:00:00|M||pmc98PV1||I|||||||||||||||||680906^^^pmc0401ORC|NW||||||||2010-08-02T18:45:00|||pmc4486^SMITH^MARY^^^DR^MDOBR|||HL7-105|SYSG||2010-08-03T08:00:00|||||||Something happened|||||DERM||||||||||||||pmc47153^HO^JONHAN^^^DR^MDTQ1|||||||||co2";
	string endFrame = Convert.ToChar(28).ToString() + Convert.ToChar(13).ToString();
	
	string hl7Message = startFrame + basehl7Message + endFrame;
	
   TcpClient  client = new TcpClient();

   client.Connect("localhost", 6661);
   
   "Connected".Dump();
   
   using(NetworkStream clientStream = client.GetStream())
   {
		ASCIIEncoding encoder = new ASCIIEncoding();
		byte[] buffer = encoder.GetBytes(hl7Message);
		
		clientStream.Write(buffer, 0 , buffer.Length);
		clientStream.Flush();
		
		"Sent Message".Dump();
		
		byte[] readBuffer = new byte[2056];
		clientStream.Read(readBuffer, 0, 2056);
		
		"Received".Dump();
		
		string response = System.Text.Encoding.ASCII.GetString(readBuffer);
		response.Dump();
   }
}