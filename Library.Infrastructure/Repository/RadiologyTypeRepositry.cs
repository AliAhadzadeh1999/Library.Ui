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
        public List<string> GetAll()
        {
            return context.RadiologyType.Select(x => x.Name).ToList();
        }

        public RadiologyType GetByName(string name)
        {

            return context.RadiologyType.AsNoTracking().FirstOrDefault(x => x.Name == name);
        }
    }
}
