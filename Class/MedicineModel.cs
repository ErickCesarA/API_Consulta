using API_consulta.Enums.Medicine_Enums;
using System.Security.Cryptography.X509Certificates;

namespace API_consulta.Class
{
    public class MedicineModel
    {
        protected string MedicineName { get; set; }
        protected int MedicineId { get; set; }
        protected int MedicineMg { get; set; }
        protected int MedicinePillNumber { get; set; }
        protected MedicineAgeUse MedicineAgeUse { get; set; }
        protected string MedicineSymptomsCure { get; set; } //Some Symptoms of a Symptoms List
        protected MedicineSeverity MedicineSeverity { get; set; }

        public MedicineModel (string MedicineName, int MedicineId, int MedicineMg, int MedicinePillNumber, MedicineAgeUse MedicineAgeUse, string MedicineSymptomsCure, MedicineSeverity MedicineSeverity)
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
            return MedicineName;
        }
        public int GetMedicineId()
        {
            return MedicineId;
        }
        public int GetMedicineMg()
        {
            return MedicineMg;
        }
        public int GetMedicinePillNumber()
        {
            return MedicinePillNumber;
        }
        public MedicineAgeUse GetMedicineAgeUse()
        {
            return MedicineAgeUse;
        }
        public string GetMedicineSynptomsCure()
        {
            return MedicineSymptomsCure;
        }
        public MedicineSeverity GetMedicineSeverity()
        {
            return MedicineSeverity;
        }



    }
}
