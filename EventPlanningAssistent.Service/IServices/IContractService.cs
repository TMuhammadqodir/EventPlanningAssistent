using EventPlanningAssistent.Service.DTOs.Contracts;
using EventPlanningAssistent.Service.Helpers;

namespace EventPlanningAssistent.Service.IServices;

public interface IContractService
{
    Task<Responce<ContractResultDTO>> CreateAsync(ContractCreationDTO dto);
    Task<Responce<ContractResultDTO>> UpdateAsync(ContractUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<ContractResultDTO>> GetByIdAsync(long id);
    Task<Responce<IEnumerable<ContractResultDTO>>> GetAllAysnc();
}
