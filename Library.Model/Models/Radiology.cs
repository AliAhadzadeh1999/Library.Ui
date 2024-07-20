namespace Library.Model.Models;

public class Radiology
{
    public Radiology()
    {
        Radiologies = new HashSet<PrescriptionRadiology>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<PrescriptionRadiology>? Radiologies{ get; set; }
}
