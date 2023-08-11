using EventPlanningAssistent.Domain.Entities.Ventors;
using EventPlanningAssistent.Service.DTOs.Contracts;
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
    Task<Responce<VentorResultDTO>> GetByTelNumberAsync(string telNumber);
    Task<Responce<IEnumerable<VentorResultDTO>>> SearchByNameAsync(string name);
    Task<Responce<IEnumerable<ContractResultDTO>>> GetAllContractOfVentorAsync(long id);
}
