namespace Library.Model.Models;

public class Medicine
{
    public Medicine()
    {
        prescriptionMedicines = new HashSet<PrescriptionMedicine>();
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public long Price { get; set; }

    public ICollection<PrescriptionMedicine>? prescriptionMedicines { get; set; }

}
