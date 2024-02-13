using SKIV.Components.Models;

namespace SKIV.Components.Service;

public interface IVolunteerService
{
    public List<Volunteer> GetVolunteers();
    public void AddVolunteer(Volunteer volunteer);
}