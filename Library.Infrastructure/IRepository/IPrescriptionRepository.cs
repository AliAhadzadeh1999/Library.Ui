using Library.Model.Models;

namespace Library.Infrastructure.IRepository
{
    public interface IPrescriptionRepository
    {
        public void Add(Prescription prescription);
    }
}
