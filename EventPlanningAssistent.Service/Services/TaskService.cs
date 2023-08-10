using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Service.DTOs.Tasks;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;
using EventPlanningAssistent.Service.Mappers;

namespace EventPlanningAssistent.Service.Services;

public class TaskService : ITaskService
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public TaskService()
    {
        unitOfWork = new UnitOfWork();

        mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
    }

    public Task<Responce<TaskResultDTO>> CreateAsync(TaskCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<TaskResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<TaskResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<TaskResultDTO>> UpdateAsync(TaskUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
