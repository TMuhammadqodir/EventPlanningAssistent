using EventPlanningAssistent.Domain.Commons;

namespace EventPlanningAssistent.Data.IRepositories.Commons;

public interface IRepository<T> where T : Auditable
{
    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> GetByIdAsync(long id);
    IQueryable<T> GetAll();
    Task<int> SaveAsync();
}
