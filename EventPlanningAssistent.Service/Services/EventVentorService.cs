using EventPlanningAssistent.Service.DTOs.EventVentors;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;

namespace EventPlanningAssistent.Service.Services;

public class EventVentorService : IEventVentorServise
{
    public Task<Responce<EventVentorResultDTO>> CreateAsync(EventVentorCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<EventVentorResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventVentorResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventVentorResultDTO>> UpdateAsync(EventVentorUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
