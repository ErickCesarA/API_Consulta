using API_consulta.Class.Patient;
using API_consulta.Enums.Patient_Enums;
using API_consulta.Managemet.Interface;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace API_consulta.Class

{
    public class PatientModel
    {
        protected int PatientId { get; set; }
        protected string? PatientName { get; set; }
        protected int PatientAge { get; set; }
        protected PatientSex PatientSex { get; set; }
        protected bool Pregnant { get; set; }
        protected bool Comorbidity { get; set; }
        [NotMapped]
        protected ComorbidityModel? WhichComorbidity { get; set; }
        protected bool DrugAllergy { get; set; }
        [NotMapped]
        protected DrugAllergyModel? WhichDrugAllergy { get; set; }

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
        public ComorbidityModel? GetWhichComobidity()
        {
            return this.WhichComorbidity;
        }
        public bool? GetDrugAllergy()
        {
            return this.DrugAllergy;
        }
        public DrugAllergyModel? GetWhichDrugAllergy()
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
