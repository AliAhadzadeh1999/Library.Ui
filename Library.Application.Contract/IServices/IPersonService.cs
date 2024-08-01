using Library.Model.Models;

namespace Library.Application.Contract.IServices
{
    public interface IPersonService
    {
        Person GetById(string nationalId);
        public void Add(Person person);
        public void Update(Person person);
        public void Delete(Person person);
    }
}
