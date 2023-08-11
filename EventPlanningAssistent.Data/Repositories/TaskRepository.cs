using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Attendees;
using EventPlanningAssistent.Domain.Entities.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.Repositories;

public class TaskRepository : Repository<TaskEntity> , ITaskRepository
{
    private readonly AppDbContext appDbContext;

    public TaskRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public IQueryable<TaskEntity> GetAllAttendeeOfTask(long id)
        => appDbContext.Tasks.Include(t => t.attendees).Where(t => t.Id == id).AsQueryable();
}
