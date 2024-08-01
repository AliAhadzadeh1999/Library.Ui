using Library.Application.Contract.IServices;
using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;
using Library.Model.Models;
namespace Library.Application.Services;

public class MedicineTypeService : IMedicineTypeService
{
    private readonly IMedicineTypeRepository medicineTypeRepository;

    public MedicineTypeService()
    {
        medicineTypeRepository = new MedicineTypeRepository();
    }
    public List<Medicine> GetAll()
    {
        return medicineTypeRepository.GetAll();
    }

    public Medicine GetByName(string name)
    {
        return medicineTypeRepository.GetByName(name);
    }
}
