using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;

namespace Library.Infrastructure.Repository;

public class RadiologyRepositry : IRadiologyRepositry
{
    private readonly LibraryContext context;
    public RadiologyRepositry()
    {
        context = new LibraryContext();
    }
    public void Add(PrescriptionRadiology prescriptionRadiology)
    {
        context.PrescriptionRadiology.Add(prescriptionRadiology);
        context.SaveChanges();
    }

    public IQueryable<Radiology> GetAll()
    {
        return context.Radiology;
    }
}
