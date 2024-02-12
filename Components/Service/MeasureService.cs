using Microsoft.EntityFrameworkCore;
using SKIV.Components.DataBase;
using SKIV.Components.Models;

namespace SKIV.Components.Service;

public class MeasureService : IMeasureService
{
    private readonly ApplicationContext _dbContext;

    public MeasureService(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddMeasure(Measure measure)
    {
        try
        {
            _dbContext.Measures.Add(measure);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Ошибка при добавлении события", ex);
        }
    }

    public async Task<List<Measure>> GetMeasures()
    {
        try
        {
            return await _dbContext.Measures.ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Ошибка при получении списка событий", ex);
        }
    }
}