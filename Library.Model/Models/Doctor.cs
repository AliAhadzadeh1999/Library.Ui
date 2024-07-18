using System.ComponentModel.DataAnnotations;

namespace Library.Model.Models;

public class Doctor
{
    public Doctor()
    {
        Prescriptions = new HashSet<Prescription>();
    }
    public int Id { get; set; }
    [StringLength(64)]
    public string? Name { get; set; }
    [StringLength(7)]
    public string? MedicalEducationNumber { get; set; }
    public ICollection<Prescription>? Prescriptions { get; set; }


}
