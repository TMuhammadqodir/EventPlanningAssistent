using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.Tasks;
using EventPlanningAssistent.Domain.Entities.Ventors;
using EventPlanningAssistent.Service.DTOs.Tasks;
using EventPlanningAssistent.Service.DTOs.Ventors;
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

    public async Task<Responce<TaskResultDTO>> CreateAsync(TaskCreationDTO dto)
    {
        EventEntity existEvent = await unitOfWork.events.GetByIdAsync(dto.EventId);

        if (existEvent is null)
            return new Responce<TaskResultDTO>
            {
                StatusCode = 404,
                Message = "This eventId was not found",
            };

        TaskEntity entity = mapper.Map<TaskEntity>(dto);

        await unitOfWork.tasks.CreateAsync(entity);
        await unitOfWork.SaveAsync();

        TaskResultDTO TaskResult = mapper.Map<TaskResultDTO>(dto);

        return new Responce<TaskResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = TaskResult
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        TaskEntity existTask = await unitOfWork.tasks.GetByIdAsync(id);

        if (existTask is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This Task was not found",
                Result = false
            };

        unitOfWork.tasks.Delete(existTask);
        await unitOfWork.SaveAsync();

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Result = true
        };
    }

    public async Task<Responce<TaskResultDTO>> UpdateAsync(TaskUpdateDTO dto)
    {
        TaskEntity existTask = await unitOfWork.tasks.GetByIdAsync(dto.Id);

        if (existTask is null)
            return new Responce<TaskResultDTO>
            {
                StatusCode = 404,
                Message = "This Task was not found",
            };

        var TaskUpdate = mapper.Map(dto, existTask);

        unitOfWork.tasks.Update(TaskUpdate);
        await unitOfWork.SaveAsync();

        var resultTask = mapper.Map<TaskResultDTO>(TaskUpdate);

        return new Responce<TaskResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultTask
        };
    }

    public async Task<Responce<IEnumerable<TaskResultDTO>>> GetAllAysnc()
    {

        var Tasks = unitOfWork.tasks.GetAll();

        var resultTasks = new List<TaskResultDTO>();

        foreach (TaskEntity entity in Tasks)
        {
            resultTasks.Add(mapper.Map<TaskResultDTO>(entity));
        }

        return new Responce<IEnumerable<TaskResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultTasks
        };
    }

    public async Task<Responce<TaskResultDTO>> GetByIdAsync(long id)
    {
        TaskEntity existTask = await unitOfWork.tasks.GetByIdAsync(id);

        if (existTask is null)
            return new Responce<TaskResultDTO>
            {
                StatusCode = 404,
                Message = "This Task was not found",
            };

        var resultTask = mapper.Map<TaskResultDTO>(existTask);

        return new Responce<TaskResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultTask
        };
    }
}