using Library.Application.Contract.DTOs.Prescriptions;
using Library.Application.Contract.IServices;
using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;
using Library.Model.Models;

namespace Library.Application.Services;

public class PrescriptionService : IPrescriptionService
{
    private readonly IPrescriptionRepository prescriptionRepository;

    public PrescriptionService()
    {
        prescriptionRepository = new PrescriptionRepository();
    }
    public void Add(PrescriptionMedicineAddDto prescriptionAddDto)
    {

        var prescription = MapTo(prescriptionAddDto);
        prescription.PrescriptionMedicines = prescriptionAddDto.Selected
            .Select(m => new PrescriptionMedicine { MedicineId = m }).
            ToList();
        prescriptionRepository.Add(prescription);
    }

    public void Add(PrescriptionRadiologyAddDto prescriptionRadiologyAddDto)
    {

        var prescription = MapTo(prescriptionRadiologyAddDto);
        prescription.PrescriptionRadiologies = prescriptionRadiologyAddDto.Selected
            .Select(m => new PrescriptionRadiology { RadiologyId = m })
            .ToList();
        prescriptionRepository.Add(prescription);
    }

    private Prescription MapTo(PrescriptionMedicineAddDto prescriptionAddDto)
    {
        return new Prescription()
        {
            DrId = prescriptionAddDto.DrId,
            PersonId = prescriptionAddDto.PersonId,
        };
    }

    private Prescription MapTo(PrescriptionRadiologyAddDto prescriptionRadiologyAddDto)
    {
        return new Prescription()
        {
            DrId = prescriptionRadiologyAddDto.DrId,
            PersonId = prescriptionRadiologyAddDto.PersonId,
        };
    }
}
