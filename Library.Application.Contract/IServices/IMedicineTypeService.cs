using Library.Model.Models;

namespace Library.Application.Contract.IServices
{
    public interface IMedicineTypeService
    {
        public List<Medicine> GetAll();
        public Medicine GetByName(string name);
    }
}
