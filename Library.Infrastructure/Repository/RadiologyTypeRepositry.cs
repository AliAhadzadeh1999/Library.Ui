using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repository
{
    public class RadiologyTypeRepositry : IRadiologyTypeRepositry
    {
        private readonly LibraryContext context;

        public RadiologyTypeRepositry()
        {
            context = new LibraryContext();
        }
        public List<Radiology> GetAll()
        {
            return context.Radiology.ToList();
        }

        public Radiology GetByName(string name)
        {

            return context.Radiology.AsNoTracking().FirstOrDefault(x => x.Name == name);
        }
    }
}
