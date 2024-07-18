using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Library.Infrastructure.Repository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly LibraryContext context;
        public PrescriptionRepository()
        {
            context = new LibraryContext();
        }
        public void Add(Prescription prescription)
        {
            context.Prescription.Add(prescription);
            context.SaveChanges();
        }
    }
}
