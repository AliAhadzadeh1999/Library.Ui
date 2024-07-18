namespace Library.Model.Models;

public class RadiologyType
{
    public RadiologyType()
    {
        Radiologies = new HashSet<Radiology>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<Radiology>? Radiologies{ get; set; }
}
