namespace Library.Model.Models;

public class MedicineType
{
    public MedicineType()
    {
        Medicine = new HashSet<Medicine>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<Medicine>? Medicine{ get; set; }

}
