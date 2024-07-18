namespace Library.Model.Models;

public class Laboratory
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int LaboratoryTypeId { get; set; }
    public LaboratoryType? LaboratoryType { get; set; }
}
