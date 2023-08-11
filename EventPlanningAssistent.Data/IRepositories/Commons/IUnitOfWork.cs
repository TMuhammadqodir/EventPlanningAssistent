namespace EventPlanningAssistent.Data.IRepositories.Commons;

public interface IUnitOfWork : IDisposable
{
    ITaskRepository tasks { get; }
    IEventRepository events { get; }
    IVentorRepository ventors { get; }
    IContractRepository contracts { get; }
    IAttendeeRepository attendees { get; }
    IEventVentorRepository eventVentors { get; }
    Task<int> SaveAsync();
}
