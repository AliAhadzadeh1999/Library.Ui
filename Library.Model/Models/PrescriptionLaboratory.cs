namespace Library.Model.Models;

public class PrescriptionLaboratory
{
    public int Id { get; set; }
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }
    public int LaboratoryTypeId { get; set; }
    public Laboratory? LaboratoryType { get; set; }
}
