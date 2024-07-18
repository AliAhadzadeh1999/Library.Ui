using System.ComponentModel.DataAnnotations;

namespace Library.Model.Models;

public class Person
{
    public Person()
    {
        Prescriptions = new HashSet<Prescription>();
        Insurances = new HashSet<Insurance>();

    }
    public int Id { get; set; }
    [StringLength(64),Required]

    public string? Name { get; set; }
    [StringLength(64),Required]
    public string? Family { get; set; }
    [StringLength(64), Required]
    public string? FatherName { get; set; }
    [StringLength(10),Required]
    public string? DateOfBirth { get; set; }
    [StringLength(10), Required]
    public string? NationalId { get; set; }

    public ICollection<Prescription>? Prescriptions { get; set; }
    public ICollection<Insurance>? Insurances { get; set; }


}
