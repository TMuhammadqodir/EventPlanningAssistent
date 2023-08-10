using EventPlanningAssistent.Service.DTOs.Tasks;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;

namespace EventPlanningAssistent.Service.Services;

public class TaskService : ITaskService
{
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
