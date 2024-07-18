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
    public class MedicineTypeRepository : IMedicineTypeRepository
    {
        private readonly LibraryContext context;

        public MedicineTypeRepository()
        {
            context = new LibraryContext();
        }
        public List<string> GetAll()
        {
            return context.MedicineType.Select(x => x.Name).ToList();
        }

        public MedicineType GetByName(string name)
        {
            return context.MedicineType.AsNoTracking().FirstOrDefault(x => x.Name == name);
        }
    }
}
