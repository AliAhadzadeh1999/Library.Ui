using Library.Application.Contract.IServices;
using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;
using Library.Model.Models;

namespace Library.Application.Services;

public class InsuranceService : IInsuranceService
{
    private readonly IInsuranceRepository insuranceRepository;

    public InsuranceService()
    {
        insuranceRepository = new InsuranceRepository();
    }
    public Insurance GetById(int id)
    {
        return insuranceRepository.GetById(id);
    }
}
