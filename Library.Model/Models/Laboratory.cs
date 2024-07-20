namespace Library.Model.Models;

public class Laboratory
{
    public Laboratory()
    {
        Laboratories = new HashSet<PrescriptionLaboratory>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<PrescriptionLaboratory>? Laboratories { get; set; }
}
