using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.IRepositories.Commons;

namespace EventPlanningAssistent.Data.Repositories.Commons;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext appDbContext;

    public UnitOfWork()
    {
        this.appDbContext = new AppDbContext();
        this.tasks = new TaskRepository(appDbContext);
        this.events = new EventRepository(appDbContext);
        this.ventors = new VentorRepository(appDbContext);
        this.attendees = new AttendeeRepository(appDbContext);
        this.contracts = new ContractRepository(appDbContext);
        this.eventVentors = new EventVentorRepository(appDbContext);
    }

    public ITaskRepository tasks { get; }
    public IEventRepository events { get; }
    public IVentorRepository ventors { get; }
    public IAttendeeRepository attendees { get; }
    public IContractRepository contracts { get; }
    public IEventVentorRepository eventVentors { get; }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    public Task<int> SaveAsync()
        => appDbContext.SaveChangesAsync();
}
