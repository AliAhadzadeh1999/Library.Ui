using System.Reflection.Metadata.Ecma335;

namespace Library.Model.Models;

public class Prescription
{
    public Prescription()
    {
        Radiologies = new HashSet<Radiology>();
        Labratories = new HashSet<Labratory>();
        Medicines = new HashSet<Medicine>();
    }
    public int Id { get; set; }
    public int DrId { get; set; }
    public Dr Dr { get; set; }    
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public ICollection<Radiology>? Radiologies{ get; set; }
    public ICollection<Labratory>? Labratories { get; set; }
    public ICollection<Medicine>? Medicines { get; set; }
}
