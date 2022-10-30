using System.Security.Cryptography.X509Certificates;

namespace API_consulta.Class
{
    public class MedicineModel
    {
        protected string MedicineName { get; set; }
        protected string MedicineID { get; set; }
        protected int MedicineMg { get; set; }
        protected int MedicinePillNumber { get; set; }
        protected int MedicineAgeUse { get; set; }
        protected string MedicineSymptomsCure { get; set; }
        protected string MedicineSeverity { get; set; }

        public MedicineModel (string MedicineName, string MedicineID, int MedicineMg, int MedicinePillNumber, int MedicineAgeUse, string MedicineSymptomsCure, string MedicineSeverity)
        {
            this.MedicineName = MedicineName;
            this.MedicineID = MedicineID;
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
        public string GetMedicineID()
        {
            return MedicineID;
        }
        public int GetMedicineMg()
        {
            return MedicineMg;
        }
        public int GetMedicinePillNumber()
        {
            return MedicinePillNumber;
        }
        public int GetMedicineAgeUse()
        {
            return MedicineAgeUse;
        }
        public string GetMedicineSynptomsCure()
        {
            return MedicineSymptomsCure;
        }
        public string GetMedicineSeverity()
        {
            return MedicineSeverity;
        }



    }
}
