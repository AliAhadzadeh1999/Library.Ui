using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;

namespace Library.Infrastructure.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly LibraryContext context;

        public MedicineRepository()
        {
            context = new LibraryContext();
        }

        public void Add(PrescriptionMedicine prescriptionMedicine)
        {
            context.PrescriptionMedicine.Add(prescriptionMedicine);
            context.SaveChanges();
        }

        public IQueryable<Medicine> GetAll()
        {
            return context.Medicine;
        }

    }
}
