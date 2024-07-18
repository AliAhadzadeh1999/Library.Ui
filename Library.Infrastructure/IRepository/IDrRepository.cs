using Library.Model.Models;

namespace Library.Infrastructure.IRepository
{
    public interface IDrRepository
    {
        public Dr GetById(int id);
        public void Add();
    }
}
