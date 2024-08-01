using Library.Model.Models;

namespace Library.Application.Contract.IServices
{
    public interface IRadiologyTypeService
    {
        public List<Radiology> GetAll();
        public Radiology GetByName(string name);
    }
}
