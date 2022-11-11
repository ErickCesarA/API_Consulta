
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using API_consulta.Enums;

namespace API_consulta.Class
{
    public class MedicineModel
    {
        protected int MedicineId;
        protected string? MedicineName;
        protected int MedicineMg;
        protected int MedicinePillNumber;
        protected MedicineAgeUse MedicineAgeUse;
        //MedicineSymptomsCure 
        protected MedicineSeverity MedicineSeverity;

        public int medicineId
        {
            get { return MedicineId; }
            set { MedicineId = value; }
        }
        public string? medicineName
        {
           get{ return MedicineName; }
           set{ MedicineName = value; } 
        }
        public int medicineMg
        {
            get { return MedicineMg; }
            set { MedicineMg = value; }
            
        }
        public int medicinePillNumber
        {
            get { return MedicinePillNumber; }
            set { MedicinePillNumber = value; }
           
        }
        public MedicineAgeUse medicineAgeUse
        {
            get { return MedicineAgeUse; }
            set { MedicineAgeUse = value; }
        }
     
        public MedicineSeverity medicineSeverity
        {
            get { return MedicineSeverity; }
            set { MedicineSeverity = value; }
        }
        public class ExpressionsPropertySimplify 
        {
            public static readonly Expression<Func<MedicineModel, object?>> MedicineId = x => x.MedicineId;
            public static readonly Expression<Func<MedicineModel, string>> MedicineName = x => x.MedicineName;
            public static readonly Expression<Func<MedicineModel, MedicineAgeUse>> MedicineAgeUse = x => x.MedicineAgeUse;
            public static readonly Expression<Func<MedicineModel, int>> MedicinePillNumber = x => x.MedicinePillNumber;
            public static readonly Expression<Func<MedicineModel, int>> MedicineMg = x => x.MedicineMg;
            public static readonly Expression<Func<MedicineModel, MedicineSeverity>> MedicineSeverity = x => x.MedicineSeverity;
        }



    }
}
