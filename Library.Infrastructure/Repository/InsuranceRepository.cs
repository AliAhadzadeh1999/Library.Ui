using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repository
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly LibraryContext context;
        public InsuranceRepository()
        {
            context = new LibraryContext();
        }
        public Insurance GetById(int id)
        {
            return context.Insurance.Include(x => x.InsuranceType).AsNoTracking().FirstOrDefault();

        }
    }
}
