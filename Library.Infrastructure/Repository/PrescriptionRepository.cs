using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;

namespace Library.Infrastructure.Repository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly LibraryContext context;
        public PrescriptionRepository()
        {
            context = new LibraryContext();
        }

        //TODO Must Add SameTime Prescription and PrescriptionMedicine
        public void Add(Prescription prescription)
        {
            context.Prescription?.Add(prescription);
            context.SaveChanges();
            
        }
    }
}
