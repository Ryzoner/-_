using SKIV.Components.Models;

namespace SKIV.Components.Service;

public interface IMeasureService
{
    Task<List<Measure>> GetMeasures();
    Task AddMeasure(Measure measure);
}
