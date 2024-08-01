using Library.Model.Models;

namespace Library.Application.Contract.IServices
{
    public interface IInsuranceService
    {
        public Insurance GetById(int id);
    }
}
