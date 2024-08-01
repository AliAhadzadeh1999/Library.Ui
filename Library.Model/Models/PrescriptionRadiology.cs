namespace Library.Model.Models;

public class PrescriptionRadiology
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int RadiologyId { get; set; }
    public Radiology? Radiology { get; set; }
}
