using API_consulta.Class;
using API_consulta.Management.Interface;

namespace API_consulta.Management
{
    public class MedicineManagement : IMedicineManagement
    {
        public Task<MedicineModel> SerchMedicine(int ID)
        {
            throw new NotImplementedException();
        }
        public Task<List<MedicineModel>> GetAllMedicine()
        {
            throw new NotImplementedException();
        }

        public Task<MedicineModel> AddMedicine(MedicineModel Medicine)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DelMedicine(int id)
        {
            throw new NotImplementedException();
        }
    }
}
