using API_consulta.Enums.Medicine_Enums;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_consulta.Class
{
    public class MedicineModel
    {
        protected string MedicineName { get; set; }
        protected int MedicineId { get; set; }
        protected int MedicineMg { get; set; }
        protected int MedicinePillNumber { get; set; }
        protected MedicineAgeUse MedicineAgeUse { get; set; }
        [NotMapped]
        protected List<SymptomsModel>? MedicineSymptomsCure { get; set; } //Some Symptoms of a Symptoms List
        protected MedicineSeverity MedicineSeverity { get; set; }

        public MedicineModel (string MedicineName, int MedicineId, int MedicineMg, int MedicinePillNumber, MedicineAgeUse MedicineAgeUse, MedicineSeverity MedicineSeverity)
        {
            this.MedicineName = MedicineName;
            this.MedicineId = MedicineId;
            this.MedicineMg = MedicineMg;
            this.MedicinePillNumber = MedicinePillNumber;
            this.MedicineAgeUse = MedicineAgeUse;
            this.MedicineSymptomsCure = MedicineSymptomsCure;
            this.MedicineSeverity = MedicineSeverity;
        }
        public string GetMedicineName()
        {
            return this.MedicineName;
        }
        public int GetMedicineId()
        {
            return this.MedicineId;
        }
        public int GetMedicineMg()
        {
            return this.MedicineMg;
        }
        public int GetMedicinePillNumber()
        {
            return this.MedicinePillNumber;
        }
        public MedicineAgeUse GetMedicineAgeUse()
        {
            return this.MedicineAgeUse;
        }
        public List<SymptomsModel>? GetMedicineSynptomsCure()
        {
            return this.MedicineSymptomsCure;
        }
        public MedicineSeverity GetMedicineSeverity()
        {
            return this.MedicineSeverity;
        }
        public class ExpressionsPropertySimplify //put in a separate method later
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
