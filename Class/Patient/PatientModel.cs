using API_consulta.Class.Patient;
using API_consulta.Enums.Patient_Enums;
using API_consulta.Managemet.Interface;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API_consulta.Class

{
    public class PatientModel 
    {
        protected int PatientId { get; set; }
        protected string? PatientName { get; set; }
        protected int PatientAge { get; set; }
        protected PatientSex? PatientSex { get; set; }
        protected bool Pregnant { get; set; }
        protected bool Comorbidity { get; set; }
        protected WhichComorbidity? WhichComorbidity { get; set; }
        protected bool DrugAllergy { get; set; }
        protected WhichDrugAllergy? WhichDrugAllergy { get; set; }

        public PatientModel(int PatientId, string PatientName, int PatientAge, PatientSex PatientSex, bool Pregnant, bool Comorbidity, WhichComorbidity WhichComorbidity, bool DrugAllergy, WhichDrugAllergy WhichDrugAllergy)
        {
            this.PatientId = PatientId;
            this.PatientName = PatientName;
            this.PatientAge = PatientAge;
            this.PatientSex = PatientSex;
            this.Pregnant = Pregnant;
            this.Comorbidity = Comorbidity;
            this.WhichComorbidity = WhichComorbidity;
            this.DrugAllergy = DrugAllergy;
            this.WhichDrugAllergy = WhichDrugAllergy;
        }

        public int GetPatientId()
        {
            return PatientId;
        }
        public string? GetPatientName()
        {
            return PatientName;
        }
        public int GetPatientAge()
        {
            return PatientAge;
        }
        public PatientSex? GetPatientSex()
        {
            return PatientSex;
        }
        public bool GetPregnat()
        {
            return Pregnant;
        }
        public bool GetComorbidity()
        {
            return Comorbidity;

        }
        public WhichComorbidity? GetWhichComobidity()
        {
            return WhichComorbidity;
        }
        public bool? GetDrugAllergy()
        {
            return DrugAllergy;
        }
        public WhichDrugAllergy? GetWhichDrugAllergy()
        {
            return WhichDrugAllergy;
        }
    }   
}
