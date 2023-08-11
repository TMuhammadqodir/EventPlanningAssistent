using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Entities.Tasks;

namespace EventPlanningAssistent.Data.IRepositories;

public interface ITaskRepository : IRepository<TaskEntity>
{
    IQueryable<TaskEntity> GetAllAttendeeOfTask(long id);
}
