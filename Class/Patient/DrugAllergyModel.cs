using System.Linq.Expressions;

namespace API_consulta.Class.Patient
{
    public class DrugAllergyModel
    {
        public int AllergyId { protected get;  set; }
        public string AllergyName { protected get;  set; }
        public string? AllergyDescription { protected get;  set; }

        public DrugAllergyModel(int AllergyId, string allergyName, string? allergyDescription)
        {
            this.AllergyId = AllergyId;
            this.AllergyName = allergyName;
            this.AllergyDescription = allergyDescription;
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
        public class ExpressionsPropertySimplify
        {
            public static readonly Expression<Func<DrugAllergyModel, object?>> AllergyId = x => x.AllergyId;
            public static readonly Expression<Func<DrugAllergyModel, string>> AllergyName = x => x.AllergyName;
            public static readonly Expression<Func<DrugAllergyModel, string?>> AllergyDescription = x => x.AllergyDescription;
        }
    }
}
