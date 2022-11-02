namespace API_consulta.Class.Patient
{
    public class WhichComorbidity
    {
        protected string ComorbidityName { get; set; }
        protected string ComorbidityDescription { get; set; }
        public WhichComorbidity (string ComotbidityName, string ComorbidityDescription)
        {
            this.ComorbidityName = ComotbidityName;
            this.ComorbidityDescription = ComorbidityDescription;   
        }
        public string GetComorbidityName()
        {
            return ComorbidityName;
        }
        public string GetComorbidityDescription()
        {
            return ComorbidityDescription;
        }
    }
}
