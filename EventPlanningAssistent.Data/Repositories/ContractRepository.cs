using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Contracts;

namespace EventPlanningAssistent.Data.Repositories;

public class ContractRepository : Repository<ContractEntity>, IContractRepository
{
    private readonly AppDbContext appDbContext;

    public ContractRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        this.appDbContext = appDbContext;
    }
}
