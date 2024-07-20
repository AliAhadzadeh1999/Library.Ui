using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore;
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

        public void Add(PrescriptionMedicine prescriptionMedicine)
        { 
            context.PrescriptionMedicine.Add(prescriptionMedicine);
            context.SaveChanges();
        }

    }
}
