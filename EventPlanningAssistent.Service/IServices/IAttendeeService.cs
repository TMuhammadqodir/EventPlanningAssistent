using EventPlanningAssistent.Service.DTOs.Attendees;
using EventPlanningAssistent.Service.Helpers;

namespace EventPlanningAssistent.Service.IServices;

public interface IAttendeeService
{
    Task<Responce<AttendeeResultDTO>> CreateAsync(AttendeeCreationDTO dto);
    Task<Responce<AttendeeResultDTO>> UpdateAsync(AttendeeUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<AttendeeResultDTO>> GetByIdAsync(long id);
    Task<Responce<IEnumerable<AttendeeResultDTO>>> GetAllAysnc();
    Task<Responce<AttendeeResultDTO>> GetByTelNumberAsync(string telNumber);
    Task<Responce<IEnumerable<AttendeeResultDTO>>> SearchByNameAsync(string name);
}
