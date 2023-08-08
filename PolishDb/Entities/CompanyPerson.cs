using PolishDb.Entities;

public class CompanyPerson
{
    public int CompanyId { get; set; }
    public int PersonId { get; set; }
    public Company Company { get; set; } = new Company();
    public Person Person { get; set; } = new Person();

    public int EmploymentTypeId { get; set; }
    public EmploymentType EmploymentType { get; set; }
}