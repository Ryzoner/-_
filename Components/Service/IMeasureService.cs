using SKIV.Components.Models;

namespace SKIV.Components.Service;

public interface IMeasureService
{
    public List<Measure> GetMeasures();
    public void AddMeasure(Measure measure);
}