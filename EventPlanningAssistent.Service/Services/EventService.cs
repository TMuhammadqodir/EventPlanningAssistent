using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;

namespace EventPlanningAssistent.Service.Services;

public class EventService : IEventService
{
    public Task<Responce<EventResultDTO>> CreateAsync(EventCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<EventResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventResultDTO>> UpdateAsync(EventUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
