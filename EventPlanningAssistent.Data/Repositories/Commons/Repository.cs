using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Commons;

namespace EventPlanningAssistent.Data.Repositories.Commons;

public class Repository<T> : IRepository<T> where T : Auditable
{
    public Task CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
