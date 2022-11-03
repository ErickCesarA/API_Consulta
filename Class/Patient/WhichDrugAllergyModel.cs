using System.Linq.Expressions;

namespace API_consulta.Class.Patient
{
    public class WhichDrugAllergyModel
    {
        protected string AllergyName { get; set; }
        protected string? AllergyDescription{ get; set; }

        public WhichDrugAllergyModel (string allergyName, string? allergyDescription)
        {
            AllergyName = allergyName;
            AllergyDescription = allergyDescription;
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
            public static readonly Expression<Func<WhichDrugAllergyModel, string>> ComorbidityName = x => x.AllergyName;
            public static readonly Expression<Func<WhichDrugAllergyModel, string?>> ComorbidityDescription = x => x.AllergyDescription;
        }
    }
}
