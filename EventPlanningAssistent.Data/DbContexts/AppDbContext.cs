using EventPlanningAssistent.Data.Constants;
using EventPlanningAssistent.Domain.Entities.Attendees;
using EventPlanningAssistent.Domain.Entities.Contracts;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.EventVentors;
using EventPlanningAssistent.Domain.Entities.Tasks;
using EventPlanningAssistent.Domain.Entities.Ventors;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.DbContexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(DatabasePath.EVENT_PLANNING_ASSISTENT_DB_PATH);
    }

    public DbSet<AttendeeEntity> Attendees { get; set; }
    public DbSet<ContractEntity> Contracts { get; set; }
    public DbSet<EventEntity> Entits { get; set; }
    public DbSet<EventVentorEntity> EventVentors { get; set; }
    public DbSet<TaskEntity> Tasks { get; set; }
    public DbSet<VentorEntity> Ventors { get; set; }
}
