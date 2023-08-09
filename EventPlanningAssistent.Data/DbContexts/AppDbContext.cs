using EventPlanningAssistent.Data.Constants;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.DbContexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(DatabasePath.EVENT_PLANNING_ASSISTENT_DB_PATH);
    }
}
