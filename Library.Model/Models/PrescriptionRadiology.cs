namespace Library.Model.Models;

public class PrescriptionRadiology
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int RadiologyTypeId { get; set; }
    public Radiology? RadiologyType { get; set; }
}
