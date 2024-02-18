using Microsoft.EntityFrameworkCore;
using SKIV.Components.DataBase;
using SKIV.Components.Models;

namespace SKIV.Components.Service;

public class VolunteerService(ApplicationContext dbContext) : IVolunteerService
{
    public void AddVolunteer(Volunteer volunteer)
    {
        dbContext.Volunteers.Add(volunteer);
        dbContext.SaveChanges();
    }

    public List<Volunteer> GetVolunteers()
    {
        return dbContext.Volunteers.ToList();
    }

    public int CalculateTotalRating(int volunteerId)
    {
        var totalRating = dbContext.Participations
            .Where(p => p.Volunteer.IdVolunteer == volunteerId)
            .Sum(p => (int?)p.Score) ?? 0;
        return totalRating;
    }
}
