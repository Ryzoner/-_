using System.ComponentModel.DataAnnotations;

namespace SKIV.Components.Models;

public class Volunteer
{
    [Key] public int IdVolunteer { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string? Patronymic { get; set; }
    public string BirthDay { get; set; }
    public string? VK { get; set; }
    public bool Disability { get; set; }
    public int ClothingSize { get; set; }
    public int? Rating { get; set; }
}