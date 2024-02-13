using System.ComponentModel.DataAnnotations;

namespace SKIV.Components.Models;

public class Measure
{
    [Key] public int IdMeasure { get; set; }
    public string? MeasureName { get; set; }
    public string? Organizer { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public string? StartTime { get; set; }
    public string? EndTime { get; set; }
    public string? Place { get; set; }
    public string? Address { get; set; }
    public int TotalParticipants { get; set; }
    public int ParticipantsWithDosabilities { get; set; }
    public string? ContactFullName { get; set; }
    public int? ContactPhoneNumber { get; set; }
    public string? ContactEmail { get; set; }
    public int TotalVolunteers { get; set; }
    public int VolunteersWithDisabilities { get; set; }
    public string? DobroRu { get; set; }
    public List<Participation> VolunteerRatings { get; set; }
    public bool LP { get; set; }
    public bool LR { get; set; }
    public bool ThankYouLettersSent { get; set; }
}