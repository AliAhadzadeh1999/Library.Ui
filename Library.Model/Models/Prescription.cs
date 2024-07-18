using System.Reflection.Metadata.Ecma335;

namespace Library.Model.Models;

public class Prescription
{
    public Prescription()
    {
        Radiologies = new HashSet<Radiology>();
        Labratories = new HashSet<Laboratory>();
        Medicines = new HashSet<PrescriptionMedicine>();
    }
    public int Id { get; set; }
    public int DrId { get; set; }
    public Doctor Dr { get; set; }    
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public ICollection<Radiology>? Radiologies{ get; set; }
    public ICollection<Laboratory>? Labratories { get; set; }
    public ICollection<PrescriptionMedicine>? Medicines { get; set; }
}
