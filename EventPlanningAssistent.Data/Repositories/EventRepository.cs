using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;

namespace EventPlanningAssistent.Data.Repositories;

public class EventRepository : Repository<EventEntity>, IEventRepository
{
    private readonly AppDbContext appDbContext;

    public EventRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }
}
