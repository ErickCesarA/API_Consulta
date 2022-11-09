using System.ComponentModel;

namespace API_consulta.Enums
{
    public enum SymptomsGravity
    {
        [Description("Mild Symptoms: common remedies can solve")]
        MildSymptom = 1,
        [Description("Severe Symptoms: you will need a drug that requires a medical prescription")]
        SevereSymptoms = 2,
        [Description("Very Severe Symptoms: recommended to see a doctor")]
        VerySeverSymptoms = 3,

    }
}
