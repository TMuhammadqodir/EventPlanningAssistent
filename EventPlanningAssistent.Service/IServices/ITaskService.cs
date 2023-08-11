using EventPlanningAssistent.Domain.Entities.Tasks;
using EventPlanningAssistent.Service.DTOs.Attendees;
using EventPlanningAssistent.Service.DTOs.Tasks;
using EventPlanningAssistent.Service.Helpers;

namespace EventPlanningAssistent.Service.IServices;

public interface ITaskService
{
    Task<Responce<TaskResultDTO>> CreateAsync(TaskCreationDTO dto);
    Task<Responce<TaskResultDTO>> UpdateAsync(TaskUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<TaskResultDTO>> GetByIdAsync(long id);
    Task<Responce<IEnumerable<TaskResultDTO>>> GetAllAysnc();
    Task<Responce<IEnumerable<AttendeeResultDTO>>> GetAllAttendeeOfTaskAsync(long id);
}
