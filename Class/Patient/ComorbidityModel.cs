using System.Linq.Expressions;

namespace API_consulta.Class.Patient
{
    public class ComorbidityModel
    {
        protected int ComorbidityId { get; set; }
        protected string ComorbidityName { get; set; }
        protected string? ComorbidityDescription { get; set; }
        public ComorbidityModel (int ComorbidityId, string ComorbidityName, string ComorbidityDescription)
        {
            this.ComorbidityId = ComorbidityId;
            this.ComorbidityName = ComorbidityName;
            this.ComorbidityDescription = ComorbidityDescription;   
        }
        public int GetComorbidityId()
        {
            return this.ComorbidityId;
        }
        public string GetComorbidityName()
        {
            return this.ComorbidityName;
        }
        public string? GetComorbidityDescription()
        {
            return this.ComorbidityDescription;
        }

        public class ExpressionsPropertySimplify
        {
            public static readonly Expression<Func<ComorbidityModel, object?>> ComorbidityId = x => x.ComorbidityId;
            public static readonly Expression<Func<ComorbidityModel, string>> ComorbidityName = x => x.ComorbidityName;
            public static readonly Expression<Func<ComorbidityModel, string?>> ComorbidityDescription = x => x.ComorbidityDescription;
        }
    }
}
