using EventPlanningAssistent.Service.DTOs.Ventors;
using EventPlanningAssistent.Service.Helpers;

namespace EventPlanningAssistent.Service.IServices;

public interface IVentorService
{
    Task<Responce<VentorResultDTO>> CreateAsync(VentorCreationDTO dto);
    Task<Responce<VentorResultDTO>> UpdateAsync(VentorUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<VentorResultDTO>> GetByIdAsync(long id);
    Task<Responce<IEnumerable<VentorResultDTO>>> GetAllAysnc();
}
