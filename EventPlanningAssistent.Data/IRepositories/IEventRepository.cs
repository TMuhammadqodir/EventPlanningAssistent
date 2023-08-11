using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;

namespace EventPlanningAssistent.Data.IRepositories;

public interface IEventRepository : IRepository<EventEntity>
{
    IQueryable<EventEntity> GetAllTasksOfEvent(long id);
}
