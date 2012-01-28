<Query Kind="Statements">
  <Connection>
    <ID>195b5b9c-8d05-4cb5-9776-f50a24d9c11a</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Driver></Driver>
    <Database>TransComp</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var query = from p in PatientProcedures
where p.Status.Equals(6)
select p;

query.ToList().Count.Dump();

var q2 = from patient in Patients				
		where patient.StatusID == 6
		where patient.PatientInsurances.FirstOrDefault().InsuranceKeyMap.InsuranceKey.Equals("B0001") ||
			  patient.PatientInsurances.FirstOrDefault().InsuranceKeyMap.InsuranceKey.Equals("B0003") ||
			  patient.PatientInsurances.FirstOrDefault().InsuranceKeyMap.InsuranceKey.Equals("B0005") ||
			  patient.PatientInsurances.FirstOrDefault().InsuranceKeyMap.InsuranceBillClass.Equals("HB") ||
			  patient.PatientInsurances.FirstOrDefault().InsuranceKeyMap.InsuranceBillClass.Equals("H3")
		select patient;
			
q2.ToList().Count.Dump();