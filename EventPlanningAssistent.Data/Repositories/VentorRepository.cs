using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Ventors;

namespace EventPlanningAssistent.Data.Repositories;

public class VentorRepository : Repository<VentorEntity>, IVentorRepository
{
    private readonly AppDbContext appDbContext;

    public VentorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }
}
