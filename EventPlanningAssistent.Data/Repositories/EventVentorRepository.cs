using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.EventVentors;

namespace EventPlanningAssistent.Data.Repositories;

public class EventVentorRepository : Repository<EventVentorEntity> , IEventVentorRepository
{
    private readonly AppDbContext appDbContext;

    public EventVentorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }
}
