using API_consulta.Class.Patient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace API_consulta.Class

{
    public class PatientModel
    {
        public int PatientId { protected get; set; }
        public string? PatientName { protected get; set; }
        public int PatientAge { protected get; set; }
        public PatientSex PatientSex { protected get; set; }
        public bool Pregnant { protected get; set; }
        public bool Comorbidity { protected get; set; }
        [NotMapped]
        public virtual List<ComorbidityModel>? WhichComorbidity { protected get; set; }
        public bool DrugAllergy { protected get; set; }
        [NotMapped]
        public virtual List<DrugAllergyModel>? WhichDrugAllergy { protected get; set; }

        public PatientModel(int PatientId, string PatientName, int PatientAge, PatientSex PatientSex, bool Pregnant, bool Comorbidity, bool DrugAllergy)
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

           return this.PatientId;
        }
        public string? GetPatientName()
        {
            return this.PatientName;
        }
        public int GetPatientAge()
        {
            return this.PatientAge;
        }
        public PatientSex GetPatientSex()
        {
            return this.PatientSex;
        }
        public bool GetPregnat()
        {
            return this.Pregnant;
        }
        public bool GetComorbidity()
        {
            return this.Comorbidity;

        }
        public List<ComorbidityModel>? GetWhichComobidity()
        {
            return this.WhichComorbidity;
        }
        public bool? GetDrugAllergy()
        {
            return this.DrugAllergy;
        }
        public List<DrugAllergyModel>? GetWhichDrugAllergy()
        {
            return this.WhichDrugAllergy;
        }
        public class ExpressionsPropertySimplify //put in a separate method later
        {
            public static readonly Expression<Func<PatientModel, object?>> PatientId = x => x.PatientId;
            public static readonly Expression<Func<PatientModel, string?>> PatientName = x => x.PatientName;
            public static readonly Expression<Func<PatientModel, int>> PatientAge = x => x.PatientAge;
            public static readonly Expression<Func<PatientModel, PatientSex>> PatientSex = x => x.PatientSex;
            public static readonly Expression<Func<PatientModel, bool>> Pregnant = x => x.Pregnant;
            public static readonly Expression<Func<PatientModel, bool>> Comorbidity = x => x.Comorbidity;
            public static readonly Expression<Func<PatientModel, bool>> DrugAllergy = x => x.DrugAllergy;
          
            
        }

    }
}
