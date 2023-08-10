using EventPlanningAssistent.Service.DTOs.Attendees;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;

namespace EventPlanningAssistent.Service.Services;

public class AttendeeService : IAttendeeService
{
    public Task<Responce<AttendeeResultDTO>> CreateAsync(AttendeeCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<AttendeeResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<AttendeeResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<AttendeeResultDTO>> UpdateAsync(AttendeeUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
