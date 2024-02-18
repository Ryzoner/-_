using Microsoft.EntityFrameworkCore;
using SKIV.Components.DataBase;
using SKIV.Components.Models;

namespace SKIV.Components.Service;

public class MeasureService(ApplicationContext dbContext) : IMeasureService
{
    public void AddMeasure(Measure measure)
    {
        dbContext.Measures.Add(measure);
        dbContext.SaveChanges();
    }

    public List<Measure> GetMeasures()
    {
        return dbContext.Measures.ToList();
    }
    
    public List<Measure> GetRecentMeasures(int count)
    {
        // Запрос к базе данных для получения последних 'count' мероприятий, отсортированных по дате начала
        return dbContext.Measures
            .OrderByDescending(m => m.StartDate)
            .Take(count)
            .ToList();
    }
}
