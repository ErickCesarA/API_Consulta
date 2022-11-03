using System.Linq.Expressions;

namespace API_consulta.Class.Patient
{
    public class WhichComorbidityModel
    {
        public string ComorbidityName { get; set; }
        public string? ComorbidityDescription { get; set; }
        public WhichComorbidityModel (string ComotbidityName, string ComorbidityDescription)
        {
            this.ComorbidityName = ComotbidityName;
            this.ComorbidityDescription = ComorbidityDescription;   
        }
        public string GetComorbidityName()
        {
            return this.ComorbidityName;
        }
        public string? GetComorbidityDescription()
        {
            return this.ComorbidityDescription;
        }
        //public class ExpressionsPropertySimplify
        //{
        //    public static readonly Expression<Func<WhichComorbidityModel, string>> ComorbidityName = x => x.ComorbidityName;
        //    public static readonly Expression<Func<WhichComorbidityModel, string?>> ComorbidityDescription = x => x.ComorbidityDescription;
        //}
    }
}
