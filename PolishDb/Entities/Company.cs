using System.Collections.Generic;

namespace PolishDb.Entities;
public class Company
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string CompanyCEOName { get; set; } = string.Empty;
    public List<Person> Person { get; set; } = new List<Person>();
}
