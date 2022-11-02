using API_consulta.Class;

namespace API_consulta.Management.Interface
{
    public interface IMedicineManagement
    {
        Task<List<MedicineModel>> GetAllMedicine();
        Task<MedicineModel> SerchMedicineId(int medicine_id);
        Task<MedicineModel> AddMedicine(MedicineModel Medicine);
        Task<bool> DelMedicine(int medicine_id);
         
    }
}
