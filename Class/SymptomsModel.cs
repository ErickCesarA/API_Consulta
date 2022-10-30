namespace API_consulta.Class
{
    public class SymptomsModel
    {
        protected string SymptomsName { get; set; }
        protected string SymptomsGravity { get; set; }
        protected string? SymptomsDescription { get; set; }

        public SymptomsModel(string SymptomsName, string SymptomsGravity, string? symptomsDescription)
        {
            this.SymptomsName = SymptomsName;
            this.SymptomsGravity = SymptomsGravity;
            this.SymptomsDescription = symptomsDescription;
        }

        public string GetSymptomsName()
        {
            return SymptomsName;
        }
        public string GetSymptomsGravity()
        {
            return SymptomsGravity;
        }
        public string? GetSymptomsDescription()
        {
            return SymptomsDescription;
        }   
    }

}
