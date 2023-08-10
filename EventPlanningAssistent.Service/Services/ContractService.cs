using EventPlanningAssistent.Service.DTOs.Contracts;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;

namespace EventPlanningAssistent.Service.Services;

public class ContractService : IContractService
{
    public Task<Responce<ContractResultDTO>> CreateAsync(ContractCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<ContractResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<ContractResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<ContractResultDTO>> UpdateAsync(ContractUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
