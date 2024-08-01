using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Library.Model.Models;

public class Prescription
{
    public Prescription()
    {
        PrescriptionRadiologies = new HashSet<PrescriptionRadiology>();
        Labratories = new HashSet<PrescriptionLaboratory>();
        PrescriptionMedicines = new HashSet<PrescriptionMedicine>();
    }
    public int Id { get; set; }
    public int DrId { get; set; }
    public Doctor Dr { get; set; }    
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public ICollection<PrescriptionRadiology>? PrescriptionRadiologies { get; set; }
    public ICollection<PrescriptionLaboratory>? Labratories { get; set; }
    public ICollection<PrescriptionMedicine>? PrescriptionMedicines { get; set; }
}
