using API_consulta.Enums;
using System.Linq.Expressions;

namespace API_consulta.Class
{
    public class SymptomsModel
    {
        protected int SymptomsId { get; set; }
        protected string SymptomsName { get; set; }
        protected SymptomsGravity SymptomsGravity { get; set; }
        protected string? SymptomsDescription { get; set; }

        public SymptomsModel(int SymptomsId, string SymptomsName, SymptomsGravity SymptomsGravity, string? symptomsDescription)
        {
            this.SymptomsId = SymptomsId;
            this.SymptomsName = SymptomsName;
            this.SymptomsGravity = SymptomsGravity;
            this.SymptomsDescription = symptomsDescription;
        }
        public int GetSymptomsId()
        {
            return this.SymptomsId;
        }
        public string GetSymptomsName()
        {
            return this.SymptomsName;
        }
        public SymptomsGravity GetSymptomsGravity()
        {
            return this.SymptomsGravity;
        }
        public string? GetSymptomsDescription()
        {
            return this.SymptomsDescription;
        }
        public class ExpressionsPropertySimplify //put in a separate method later
        {
            public static readonly Expression<Func<SymptomsModel, object?>> SymptomsId = x => x.SymptomsId;
            public static readonly Expression<Func<SymptomsModel, string>> SymptomsName = x => x.SymptomsName;
            public static readonly Expression<Func<SymptomsModel, SymptomsGravity>> SymptomsGravity = x => x.SymptomsGravity;
            public static readonly Expression<Func<SymptomsModel, string?>> SymptomsDescription = x => x.SymptomsDescription;

        }
    }

}
