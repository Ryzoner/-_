using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKIV.Components.Models;

public class Participation
{
    [Key] public int IdParticipation { get; set; }
    [ForeignKey("Volunteer")] public Volunteer IdVolunteer { get; set; }
    [ForeignKey("Measure")] public Measure IdMeasure { get; set; }
    public string Role { get; set; }
}