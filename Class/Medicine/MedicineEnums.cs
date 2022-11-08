using System.ComponentModel;

namespace API_consulta.Class.Medicine
{
        public enum MedicineAgeUse
        {
            [Description("Pediatric use only")]
            PediatricUseOnly = 1,
            [Description("Adult use only")]
            AdultOnlyUse = 2,
            [Description("Adult and pedriatic use")]
            AdultAndPediatricUse = 3,
        }
        public enum MedicineSeverity
        {
            [Description("Common Drug")]
            PediatricUseOnly = 1,
            [Description("controlled drug")]
            AdultOnlyUse = 2,

        }
    }
