using Microsoft.EntityFrameworkCore;
using SKIV.Components.Models;

namespace SKIV.Components.DataBase;

public class ApplicationContext : DbContext
{
    public DbSet<Volunteer> Volunteers { get; set; }
    public DbSet<Measure> Measures { get; set; }
    public DbSet<Participation> Participations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = LocalStorage.db");
    }
}