using System;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {

        OutNetworkPatient patient;


        public OutNetworkAdapter(string newName, int newPolicyNumber) 
        {
            patient = new OutNetworkPatient (newName, newPolicyNumber);
        }

        //why don't we take out the int Procedure if we aren't using it
        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            decimal coveragePercent = patient.CoveragePercent(ProcedureCost);
            return (coveragePercent * ProcedureCost);
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        public bool IsCovered(string patientName, string policyNumber)
        {
            int nPolicyNumber = int.Parse(policyNumber);
            string covered = patient.IsCovered(patientName, nPolicyNumber);
            bool bCovered = bool.Parse(covered);
            return bCovered ;
        }
    }
}
