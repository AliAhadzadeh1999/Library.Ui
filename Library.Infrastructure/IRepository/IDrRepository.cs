using Library.Model.Models;

namespace Library.Infrastructure.IRepository
{
    public interface IDrRepository
    {
        public Doctor GetById(int id);
        public void Add();
    }
}
