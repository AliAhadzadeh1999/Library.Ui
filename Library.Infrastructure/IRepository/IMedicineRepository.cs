using Library.Model.Models;

namespace Library.Infrastructure.IRepository;

public interface IMedicineRepository
{
    public void Add(PrescriptionMedicine prescriptionMedicine);

    public IQueryable<Medicine> GetAll();
}
