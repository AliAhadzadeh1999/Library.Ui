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

        public Dr GetById(int id)
        {
            return context.Dr.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}
