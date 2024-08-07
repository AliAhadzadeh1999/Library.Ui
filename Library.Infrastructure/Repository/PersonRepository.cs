using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repository;

public class PersonRepository : IPersonRepository
{
    private readonly LibraryContext Context;

    public PersonRepository()
    {
        Context = new LibraryContext();
    }

    public void Add(Person person)
    {
        throw new NotImplementedException();
    }

    public void Delete(Person person)
    {
        throw new NotImplementedException();
    }

    public Person? GetById(string nationalId)=> Context.Person?.FirstOrDefault(x => x.NationalId == nationalId);
  
    public void Update(Person person)
    {
        throw new NotImplementedException();
    }

}
