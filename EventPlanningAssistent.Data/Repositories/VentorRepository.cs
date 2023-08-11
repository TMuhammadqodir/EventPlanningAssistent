using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Ventors;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.Repositories;

public class VentorRepository : Repository<VentorEntity>, IVentorRepository
{
    private readonly AppDbContext appDbContext;

    public VentorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public IQueryable<VentorEntity> GetAllContractOfVentor(long id)
        => appDbContext.Ventors.Include(v => v.contracts).Where(v => v.Id == id).AsQueryable();

    public async Task<VentorEntity> GetByTelNumberAsync(string telNumber)
        => await appDbContext.Ventors.FirstOrDefaultAsync(v => v.TelNumber.Equals(telNumber));

    public IQueryable<VentorEntity> SeachByName(string name)
        => appDbContext.Ventors.Where(v => v.FirstName.ToLower().Contains(name.ToLower()));
}
