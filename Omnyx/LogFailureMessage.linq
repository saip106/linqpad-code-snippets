<Query Kind="Statements" />

string s = @"<s:Envelope xmlns:a='http://www.w3.org/2005/08/addressing' xmlns:s='http://www.w3.org/2003/05/soap-envelope'>
  <s:Header>
	<a:Action s:mustUnderstand='1'>http://www.omnyx.com/2009/11/IAplisXmlPushService/CaseAccessionUpdateResponse</a:Action>
	<a:RelatesTo>urn:uuid:48a1fdc0-454e-4459-b8c2-0bf51e6458b8</a:RelatesTo>
  </s:Header>
  <s:Body>
	<CaseAccessionUpdateResponse xmlns='http://www.omnyx.com/2009/11'>
	  <CaseAccessionUpdateResult xmlns:d4p1='http://schemas.datacontract.org/2004/07/Omnyx.Shared.Contracts.APLIS' xmlns:i='http://www.w3.org/2001/XMLSchema-instance'>
		<d4p1:ErrorCode>NoErrors</d4p1:ErrorCode>
		<d4p1:ErrorMessage />
		<d4p1:IsSuccessful>true</d4p1:IsSuccessful>
	  </CaseAccessionUpdateResult>
	</CaseAccessionUpdateResponse>
  </s:Body>
</s:Envelope>";



XmlDocument xmlDoc = new XmlDocument();
xmlDoc.LoadXml(s);

XmlNamespaceManager manager = new XmlNamespaceManager(xmlDoc.NameTable);
manager.AddNamespace("s", "http://schemas.datacontract.org/2004/07/Omnyx.Shared.Contracts.APLIS"); 
XmlNode node = xmlDoc.SelectSingleNode("//s:IsSuccessful", manager).Dump();
if (node != null)
{
	string isSuccessfulValue = node.InnerText;
	isSuccessfulValue.Dump();
}