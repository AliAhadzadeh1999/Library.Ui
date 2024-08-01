using Library.Application.Contract.IServices;
using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;
using Library.Model.Models;

namespace Library.Application.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository personRepository;

    public PersonService()
    {
        personRepository = new PersonRepository();
    }
    public void Add(Person person)
    {
        personRepository.Add(person);
    }

    public void Delete(Person person)
    {
        personRepository?.Delete(person);
    }

    public Person GetById(string nationalId)
    {
        return personRepository.GetById(nationalId);
    }

    public void Update(Person person)
    {
        personRepository.Update(person);
    }
}
