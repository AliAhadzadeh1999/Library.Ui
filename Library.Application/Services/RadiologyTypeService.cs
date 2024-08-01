using Library.Application.Contract.IServices;
using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;
using Library.Model.Models;

namespace Library.Application.Services;

public class RadiologyTypeService : IRadiologyTypeService
{
    private readonly IRadiologyTypeRepositry radiologyTypeRepositry;

    public RadiologyTypeService()
    {
        radiologyTypeRepositry = new RadiologyTypeRepositry();
    }
    public List<Radiology> GetAll()
    {
        return radiologyTypeRepositry.GetAll();
    }

    public Radiology GetByName(string name)
    {
        return radiologyTypeRepositry.GetByName(name);
    }
}
