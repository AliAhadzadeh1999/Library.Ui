namespace Library.Model.Models;

public class Medicine
{
    public Medicine()
    {
        PrescriptionMedicine = new HashSet<PrescriptionMedicine>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<PrescriptionMedicine>? PrescriptionMedicine { get; set; }

}
