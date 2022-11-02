using API_consulta.Enums;

namespace API_consulta.Class
{
    public class SymptomsModel
    {
        protected string SymptomsName { get; set; }
        protected SymptomsGravity SymptomsGravity { get; set; }
        protected string? SymptomsDescription { get; set; }

        public SymptomsModel(string SymptomsName, SymptomsGravity SymptomsGravity, string? symptomsDescription)
        {
            this.SymptomsName = SymptomsName;
            this.SymptomsGravity = SymptomsGravity;
            this.SymptomsDescription = symptomsDescription;
        }

        public string GetSymptomsName()
        {
            return SymptomsName;
        }
        public SymptomsGravity GetSymptomsGravity()
        {
            return SymptomsGravity;
        }
        public string? GetSymptomsDescription()
        {
            return SymptomsDescription;
        }   
    }

}
