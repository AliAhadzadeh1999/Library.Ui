using Library.Model.Models;

namespace Library.Infrastructure.IRepository
{
    public interface IMedicineRepository
    {
        public void Add(Medicine medicine);
    }
}
