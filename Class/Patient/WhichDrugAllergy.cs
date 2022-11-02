namespace API_consulta.Class.Patient
{
    public class WhichDrugAllergy
    {
        protected string AllergyName { get; set; }
        protected string? AllergyDescription{ get; set; }

        public WhichDrugAllergy (string allergyName, string? allergyDescription)
        {
            AllergyName = allergyName;
            AllergyDescription = allergyDescription;
        }   
        public string GetAllergyName()
        {
            return AllergyName;
        }
        public string? GetAllergyDescription()
        {
            return AllergyDescription;
        }
    }
}
