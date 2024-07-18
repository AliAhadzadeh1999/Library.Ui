namespace Library.Model.Models;

public class Insurance
{
    public int Id { get; set; }
    public string? ExpireDate { get; set; }
    public string? StartDate { get; set; }
    public InsuranceType? InsuranceType { get; set; }
    public int InsuranceTypeId { get; set; }
    public int PersonId { get; set; }
    public Person? Person { get; set; }
}
