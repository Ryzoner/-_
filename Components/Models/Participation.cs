using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKIV.Components.Models;

public class Participation
{
    [Key] public int IdParticipation { get; set; }
    public Volunteer IdVolunteer { get; set; }
    public Measure IdMeasure { get; set; }
    public int Score { get; set; }
}