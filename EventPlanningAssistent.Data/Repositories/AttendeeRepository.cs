using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Attendees;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.Repositories;

public class AttendeeRepository : Repository<AttendeeEntity>, IAttendeeRepository
{
    private readonly AppDbContext appDbContext;
    public AttendeeRepository(AppDbContext appContext) : base(appContext)
    {
        this.appDbContext = appContext;
    }

    public async Task<AttendeeEntity> GetByTelNumberAsync(string telNumber)
        => await appDbContext.Attendees.FirstOrDefaultAsync(a => a.TelNumber.Equals(telNumber));
}
