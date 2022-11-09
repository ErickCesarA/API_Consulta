using API_consulta.Class;

namespace API_consulta.Management.Interface
{
    public interface IMedicineManagement
    {
        Task<MedicineModel> AddMedicine(MedicineModel Medicine);
        Task<MedicineModel> SerchMedicineId(int medicine_id);
        Task<List<MedicineModel>> GetAllMedicine();
        Task<bool> DelMedicine(int medicine_id);
         
    }
}
