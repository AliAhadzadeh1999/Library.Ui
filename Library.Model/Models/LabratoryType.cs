namespace Library.Model.Models;

public class LabratoryType
{
    public LabratoryType()
    {
        Labratorys = new HashSet<Labratory>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<Labratory>? Labratorys { get; set; }
}
