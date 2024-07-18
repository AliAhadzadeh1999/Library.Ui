using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repository
{
    public class DrRepository : IDrRepository
    {
        private readonly LibraryContext context;
        public void Add()
        {
            throw new NotImplementedException();
        }

        public Doctor GetById(int id)
        {
            return context.Doctor.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}
