namespace Library.Model.Models;

public class PrescriptionMedicine
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int MedicineTypeId { get; set; }
    public Medicine? MedicineType { get; set; }

}
