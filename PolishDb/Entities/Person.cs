using System;

namespace PolishDb.Entities;
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; } = string.Empty;
    public double Earnings { get; set; }
    public bool Wife { get; set; } = false;
    public bool Husband { get; set; } = false;
    public string? SpouseName { get; set; }
    public bool Mother { get; set; }
    public bool Father { get; set; }
    public string? MotherName { get; set; }
    public string? FatherName { get; set; }
}
