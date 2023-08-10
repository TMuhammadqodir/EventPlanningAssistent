using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.Helpers;

namespace EventPlanningAssistent.Service.IServices;

public interface IEventService
{
    Task<Responce<EventResultDTO>> CreateAsync(EventCreationDTO dto);
    Task<Responce<EventResultDTO>> UpdateAsync(EventUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<EventResultDTO>> GetByIdAsync(long id);
    Task<Responce<IEnumerable<EventResultDTO>>> GetAllAysnc();
}
