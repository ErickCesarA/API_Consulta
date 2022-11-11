using API_consulta.Enums;
using System.Linq.Expressions;

namespace API_consulta.Class
{
    public class SymptomsModel
    {
        protected int SymptomsId;
        protected string? SymptomsName;
        protected SymptomsGravity SymptomsGravity;
        protected string? SymptomsDescription;

        public int symptomsId
        {
            get { return SymptomsId; }
            set { SymptomsId = value; }
        }
        public string? symptomsName
        {
            get { return SymptomsName; }
            set { SymptomsName = value; }
        }
        public SymptomsGravity symptomsGravity
        {
            get { return SymptomsGravity; }
            set { SymptomsGravity = value; }
        }
        public string? symptomsDescription
        {
            get { return SymptomsDescription; }
            set { SymptomsDescription = value; }
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
