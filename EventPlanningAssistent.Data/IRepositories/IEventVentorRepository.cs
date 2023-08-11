using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.EventVentors;
using EventPlanningAssistent.Domain.Entities.Ventors;

namespace EventPlanningAssistent.Data.IRepositories;

public interface IEventVentorRepository : IRepository<EventVentorEntity>
{
    IQueryable<EventVentorEntity> GetAllByVentorId(long ventorId);
    IQueryable<EventVentorEntity> GetAllByEventId(long eventId);
}
