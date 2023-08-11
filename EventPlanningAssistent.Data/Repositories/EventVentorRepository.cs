using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.EventVentors;
using EventPlanningAssistent.Domain.Entities.Ventors;

namespace EventPlanningAssistent.Data.Repositories;

public class EventVentorRepository : Repository<EventVentorEntity> , IEventVentorRepository
{
    private readonly AppDbContext appDbContext;

    public EventVentorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public IQueryable<EventVentorEntity> GetAllByVentorId(long ventorId)
        => appDbContext.EventVentors.Where(ev => ev.VentorId == ventorId);

    public IQueryable<EventVentorEntity> GetAllByEventId(long eventId)
        =>  appDbContext.EventVentors.Where(ev => ev.EventId == eventId);
}
