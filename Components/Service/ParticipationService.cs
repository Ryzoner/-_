using SKIV.Components.DataBase;
using SKIV.Components.Models;

namespace SKIV.Components.Service;

public class ParticipationService(ApplicationContext dbContext)
{
    public void AddParticipation(Participation participation)
    {
        dbContext.Participations.Add(participation);
        dbContext.SaveChanges();
    }
}