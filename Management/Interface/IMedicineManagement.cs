using API_consulta.Class;

namespace API_consulta.Management.Interface
{
    public interface IMedicineManagement
    {
        Task<List<MedicineModel>> GetAllMedicine();
        Task<MedicineModel> SerchMedicine(int ID);
        Task<MedicineModel> AddMedicine(MedicineModel Medicine);
        Task<bool> DelMedicine(int id);
         
    }
}
