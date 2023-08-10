using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Service.DTOs.Contracts;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;
using EventPlanningAssistent.Service.Mappers;

namespace EventPlanningAssistent.Service.Services;

public class ContractService : IContractService
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public ContractService()
    {
        unitOfWork = new UnitOfWork();

        mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
    }

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
