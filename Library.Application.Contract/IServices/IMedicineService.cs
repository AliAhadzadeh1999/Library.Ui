using Library.Model.Models;

namespace Library.Application.Contract.IServices
{
    public interface IMedicineService
    {
        public List<Medicine> GetAll();
        public Medicine GetByName(string name);
    }
}
