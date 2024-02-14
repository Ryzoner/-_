using Microsoft.EntityFrameworkCore;
using SKIV.Components.DataBase;
using SKIV.Components.Models;

namespace SKIV.Components.Service;

public class VolunteerService(ApplicationContext dbContext) : IVolunteerService
{
    public void AddVolunteer(Volunteer volunteer)
    {
        dbContext.Volunteers.Add(volunteer);
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
    
    public List<Volunteer> SearchVolunteers(string searchQuery)
    {
        // Приводим строку поиска к нижнему регистру для сравнения без учета регистра
        string query = searchQuery.ToLower();

        // Выполняем запрос к базе данных, чтобы найти волонтеров, у которых имя или фамилия содержат поисковую строку
        var volunteers = dbContext.Volunteers
            .Where(v => v.FirstName.Contains(query, StringComparison.CurrentCultureIgnoreCase) ||
                        v.SurName.Contains(query, StringComparison.CurrentCultureIgnoreCase))
            .ToList();

        return volunteers;
    }
}
