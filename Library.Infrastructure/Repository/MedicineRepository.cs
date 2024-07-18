using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly LibraryContext context;
        public MedicineRepository()
        {
            context = new LibraryContext();
        }
        public void Add(Medicine medicine)
        {
            context.Medicine.Add(medicine);
            context.SaveChanges();
        }
    }
}
