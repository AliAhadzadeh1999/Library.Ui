using Library.Model.Models;

namespace Library.Application.Contract.DTOs.Prescriptions;

public class PrescriptionMedicineAddDto
{
    public PrescriptionMedicineAddDto()
    {
        Selected = new List<int>();
    }
    public int Id { get; set; }
    public int DrId { get; set; }
    public Doctor Dr { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }

    public ICollection<int> Selected;
}
