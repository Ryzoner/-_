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
    
    /*
    public int GetTotalRatingForVolunteer(int volunteerIdVolunteer)
    {
        // Выполняем запрос к таблице Participation для выбора всех оценок данного волонтера
        var totalRating = dbContext.Participations
            .Where(p => p.IdVolunteer == volunteerIdVolunteer) // Сравниваем IdVolunteer с переданным volunteerIdVolunteer
            .Select(p => p.Score) // Выбираем оценки волонтера
            .DefaultIfEmpty() // Гарантируем, что Sum() вернет null, если коллекция пуста
            .Sum() ?? 0; // Применяем оператор ?? для предоставления значения по умолчанию

        return totalRating;
        */
    }
