using PolishDb.Entities;

public class CompanyPerson
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int PersonId { get; set; }
    public int EmploymentTypeId { get; set; }
    public EmploymentType EmploymentType { get; set; }
}