using Library.Infrastructure.Contexts;
using Library.Model.Models;

namespace Library.Infrastructure.IRepository
{
    public interface IMedicineTypeRepository
    {
        
        public List<string> GetAll();

        public MedicineType GetByName(string name);

    }
}
