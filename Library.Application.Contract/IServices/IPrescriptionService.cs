using Library.Application.Contract.DTOs.Prescriptions;
using Library.Model.Models;

namespace Library.Application.Contract.IServices
{
    public interface IPrescriptionService
    {
        public void Add(PrescriptionMedicineAddDto prescription);
        public void Add(PrescriptionRadiologyAddDto prescription);
    }
}
