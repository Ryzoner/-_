using Microsoft.EntityFrameworkCore;
using SKIV.Components.Models;

namespace SKIV.Components.DataBase;

public class ApplicationContext : DbContext
{
    public DbSet<Volunteer> Volunteers { get; set; } = null!;
    public DbSet<Measure> Measures { get; set; } = null!;
    public DbSet<Participation> Participations { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=LocalStorage.db");
    }
}