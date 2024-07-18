namespace Library.Model.Models;

public class Radiology
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int RadiologyTypeId { get; set; }
    public RadiologyType? RadiologyType { get; set; }
}
