using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Entities.Attendees;

namespace EventPlanningAssistent.Data.IRepositories;

public interface IAttendeeRepository : IRepository<AttendeeEntity>
{
    Task<AttendeeEntity> GetByTelNumberAsync(string telNumber);
}
