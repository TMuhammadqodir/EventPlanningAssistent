using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Tasks;

namespace EventPlanningAssistent.Data.Repositories;

public class TaskRepository : Repository<TaskEntity> , ITaskRepository
{
    private readonly AppDbContext appDbContext;

    public TaskRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }
}
