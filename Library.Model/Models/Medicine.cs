namespace Library.Model.Models;

public class Medicine
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int MedicineTypeId { get; set; }
    public MedicineType? MedicineType { get; set; }

}
