using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKIV.Components.Models;

public class Participation
{
    [Key] public int IdParticipation { get; set; }
    public virtual Measure Measure { get; set; }
    public virtual Volunteer Volunteer { get; set; }
    public int Score { get; set; }
}