using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.Repositories;

public class EventRepository : Repository<EventEntity>, IEventRepository
{
    private readonly AppDbContext appDbContext;

    public EventRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public IQueryable<EventEntity> GetAllTasksOfEvent(long id)
       => appDbContext.Events.Include(e => e.Tasks).Where(e => e.Id == id).AsQueryable();
}
