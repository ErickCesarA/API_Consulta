using API_consulta.Class.Patient;

namespace API_consulta.Management.Interface.PatientInterface
{
    public interface IDrugAllergyManagement
    {
        Task<DrugAllergyModel> AddAllergy(DrugAllergyModel drug_allergy);
        Task<DrugAllergyModel> SerchAllergyId(int drug_allergy_id);
        Task<List<DrugAllergyModel>> GetAllAllergy();
        Task<bool> DelAllergy(int drug_allergy_id);
    }
}
