using System.ComponentModel;

namespace API_consulta.Enums.Medicine_Enums
{
    public enum MedicineSeverity
    {
        [Description("no prescription needed")]
        CommunDrug = 1,
        [Description("need a prescription")]
        ControlledDrug = 2,
    }
}
