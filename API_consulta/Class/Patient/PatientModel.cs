using API_consulta.Enums;
using System.Linq.Expressions;

namespace API_consulta.Class

{
    public class PatientModel
    {
        protected int PatientId;

        protected string? PatientName;

        protected int PatientAge;

        protected PatientSex PatientSex;

        protected bool Pregnant;

        //Comorbidity 
        //WhichComorbidity
        //DrugAllergy 
        //WhichDrugAllergy
        public int patientId
        {
            get { return PatientId; }
            set { PatientId = value; }
        }
        public string? patientName
        {
            get { return PatientName; }
            set { PatientName = value; }
        }
        public int patientAge
        {
            get { return PatientAge; }
            set { PatientAge = value; }
        }
        public PatientSex patientSex
        {
            get { return PatientSex; }
            set { PatientSex = value; }
        }
        public bool pregnant
        {
            get { return Pregnant; }
            set { Pregnant = value; }
        }


        public class ExpressionsPropertySimplify 
        {
            public static readonly Expression<Func<PatientModel, object?>> PatientId = x => x.PatientId;
            public static readonly Expression<Func<PatientModel, string?>> PatientName = x => x.PatientName;
            public static readonly Expression<Func<PatientModel, int>> PatientAge = x => x.PatientAge;
            public static readonly Expression<Func<PatientModel, PatientSex>> PatientSex = x => x.PatientSex;
            public static readonly Expression<Func<PatientModel, bool>> Pregnant = x => x.Pregnant;
           


        }

    }
}
