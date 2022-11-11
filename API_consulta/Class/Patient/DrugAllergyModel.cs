using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace API_consulta.Class.Patient
{
    public class DrugAllergyModel
    {
        protected int AllergyId;
        protected string? AllergyName;
        protected string? AllergyDescription;
        public int allergyId
        {
            get { return AllergyId;}
            set { AllergyId = value;}   
        }
        public string? allergyName
        {
            get { return AllergyName; }
            set { AllergyName = value; }
        }
        public string? allergyDescription
        {
            get { return AllergyDescription; }
            set { AllergyDescription = value; }
        }
        
        public class ExpressionsPropertySimplify
        {
            public static readonly Expression<Func<DrugAllergyModel, object?>> AllergyId = x => x.AllergyId;
            public static readonly Expression<Func<DrugAllergyModel, string>> AllergyName = x => x.AllergyName;
            public static readonly Expression<Func<DrugAllergyModel, string?>> AllergyDescription = x => x.AllergyDescription;
        }
    }
}
