using SKIV.Components.DataBase;
using SKIV.Components.Models;

namespace SKIV.Components.Service;

public class ParticipationService
{
    private static ApplicationContext _dbContext = null!;

    public ParticipationService(ApplicationContext context)
    {
        _dbContext = context;
    }
    public static void AddParticipation(Participation participation)
    {
        if (participation == null)
        {
            throw new ArgumentNullException(nameof(participation));
        }

        _dbContext.Participations.Add(participation);
        _dbContext.SaveChanges();
    }
}