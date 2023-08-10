using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Domain.Entities.Ventors;

namespace EventPlanningAssistent.Data.IRepositories;

public interface IVentorRepository : IRepository<VentorEntity>
{
    Task<VentorEntity> GetByTelNumberAsync(string telNumber);
}
