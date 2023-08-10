using EventPlanningAssistent.Data.DbContexts;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace EventPlanningAssistent.Data.Repositories.Commons;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly AppDbContext appDbContext;
    private readonly DbSet<T> dbSet;

    public Repository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;

        dbSet = this.appDbContext.Set<T>();
    }

    public async Task CreateAsync(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        dbSet.Entry(entity).State = EntityState.Modified;
    }
    public IQueryable<T> GetAll()
        => dbSet.AsQueryable();

    public async Task<T> GetById(long id)
        => await dbSet.FirstOrDefaultAsync(x => x.Id == id);

}
