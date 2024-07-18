namespace Library.Model.Models;

public class Labratory
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int LabratoryTypeId { get; set; }
    public LabratoryType? LabratoryType { get; set; }
}
