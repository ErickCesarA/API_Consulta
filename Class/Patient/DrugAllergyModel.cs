using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace API_consulta.Class.Patient
{
    public class DrugAllergyModel
    {
        public int AllergyId { protected get;  set; }
        public string AllergyName { protected get;  set; }
        public string? AllergyDescription { protected get;  set; }

        public DrugAllergyModel(int AllergyId, string AllergyName, string? AllergyDescription)
        {
            this.AllergyId = AllergyId;
            this.AllergyName = AllergyName;
            this.AllergyDescription = AllergyDescription;
        }
        public int GetAllergyId()
        {
            return this.AllergyId;
        }
        public string GetAllergyName()
        {
            return this.AllergyName;
        }
        public string? GetAllergyDescription()
        {
            return this.AllergyDescription;
        }
        //public bool DrugAllergy { protected get; set; }
        //[NotMapped]
        //protected virtual List<DrugAllergyModel>? WhichDrugAllergy { get; set; }
        public class ExpressionsPropertySimplify
        {
            public static readonly Expression<Func<DrugAllergyModel, object?>> AllergyId = x => x.AllergyId;
            public static readonly Expression<Func<DrugAllergyModel, string>> AllergyName = x => x.AllergyName;
            public static readonly Expression<Func<DrugAllergyModel, string?>> AllergyDescription = x => x.AllergyDescription;
        }
    }
}
