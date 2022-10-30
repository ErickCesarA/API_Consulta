using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API_consulta.Class

{
    public class PatientModel
    {
        protected string? PatientName { get; set; }
        protected int PatientAge { get; set; }
        protected string? PatientSex { get; set; }
        protected bool Pregnant { get; set; }
        protected bool Comorbidity { get; set; }
        protected string? WhichComorbidity { get; set; }
        protected bool DrugAllergy { get; set; }
        protected string? WhichDrugAllergy { get; set; }

        public PatientModel(string PatientName, int PatientAge, string PatientSex, bool Pregnant, bool Comorbidity, string WhichComorbidity, bool DrugAllergy, string WhichDrugAllergy)
        {
            this.PatientName = PatientName;
            this.PatientAge = PatientAge;
            this.PatientSex = PatientSex;
            this.Pregnant = Pregnant;
            this.Comorbidity = Comorbidity;
            this.WhichComorbidity = WhichComorbidity;
            this.DrugAllergy = DrugAllergy;
            this.WhichDrugAllergy = WhichDrugAllergy;
        }
        public string? GetPatientName()
        {
            return PatientName;
        }
        public int GetPatientAgr()
        {
            return PatientAge;
        }
        public string? GetPatientSex()
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
        public string? GetWhichComobidity()
        {
            return WhichComorbidity;
        }
        public bool? GetDrugAllergy()
        {
            return DrugAllergy;
        }
        public string? GetWihchDrugAllergy()
        {
            return WhichDrugAllergy;
        }
    }   
}
