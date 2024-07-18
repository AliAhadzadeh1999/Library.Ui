using Library.Model.Models;
using System.Data;

namespace Library.Infrastructure.IRepository;

public interface IPersonRepository
{
    Person GetById(string nationalId);
    public void Add(Person person);
    public void Update(Person person);
    public void Delete(Person person);
}
