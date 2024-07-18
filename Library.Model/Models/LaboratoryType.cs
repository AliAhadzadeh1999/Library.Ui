namespace Library.Model.Models;

public class LaboratoryType
{
    public LaboratoryType()
    {
        Laboratories = new HashSet<Laboratory>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<Laboratory>? Laboratories { get; set; }
}
