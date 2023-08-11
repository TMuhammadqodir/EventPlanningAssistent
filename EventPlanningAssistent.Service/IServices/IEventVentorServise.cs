using EventPlanningAssistent.Domain.Entities.EventVentors;
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.DTOs.EventVentors;
using EventPlanningAssistent.Service.DTOs.Ventors;
using EventPlanningAssistent.Service.Helpers;

namespace EventPlanningAssistent.Service.IServices;

public interface IEventVentorServise
{
    Task<Responce<EventVentorResultDTO>> CreateAsync(EventVentorCreationDTO dto);
    Task<Responce<EventVentorResultDTO>> UpdateAsync(EventVentorUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<EventVentorResultDTO>> GetByIdAsync(long id);
    Task<Responce<IEnumerable<EventVentorResultDTO>>> GetAllAysnc();
    Task<Responce<IEnumerable<EventResultDTO>>> GetAllEventOfVentorAsync(long ventorId);
    Task<Responce<IEnumerable<VentorResultDTO>>> GetAllVentorOfEventAsync(long eventId);
}
