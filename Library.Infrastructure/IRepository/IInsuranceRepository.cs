using Library.Model.Models;

namespace Library.Infrastructure.IRepository
{
    public interface IInsuranceRepository
    {
        public Insurance GetById(int id);
    }
}
