using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Contracts;
using EventPlanningAssistent.Domain.Entities.Ventors;
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

    public async Task<Responce<ContractResultDTO>> CreateAsync(ContractCreationDTO dto)
    {
        VentorEntity existVentor = await unitOfWork.ventors.GetByIdAsync(dto.VentorId);

        if (existVentor is null)
            return new Responce<ContractResultDTO>
            {
                StatusCode = 404,
                Message = "This VentorId was not found",
            };

        ContractEntity entity = mapper.Map<ContractEntity>(dto);

        await unitOfWork.contracts.CreateAsync(entity);
        await unitOfWork.SaveAsync();

        ContractResultDTO ContractResult = mapper.Map<ContractResultDTO>(dto);

        return new Responce<ContractResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = ContractResult
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        ContractEntity existContract = await unitOfWork.contracts.GetByIdAsync(id);

        if (existContract is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This Contract was not found",
                Result = false
            };

        unitOfWork.contracts.Delete(existContract);
        await unitOfWork.SaveAsync();

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Result = true
        };
    }

    public async Task<Responce<ContractResultDTO>> UpdateAsync(ContractUpdateDTO dto)
    {
        ContractEntity existContract = await unitOfWork.contracts.GetByIdAsync(dto.Id);

        if (existContract is null)
            return new Responce<ContractResultDTO>
            {
                StatusCode = 404,
                Message = "This Contract was not found",
            };

        var ContractUpdate = mapper.Map(dto, existContract);

        unitOfWork.contracts.Update(ContractUpdate);
        await unitOfWork.SaveAsync();

        var resultContract = mapper.Map<ContractResultDTO>(ContractUpdate);

        return new Responce<ContractResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultContract
        };
    }

    public async Task<Responce<IEnumerable<ContractResultDTO>>> GetAllAysnc()
    {
        var Contracts = unitOfWork.contracts.GetAll();

        var resultContracts = new List<ContractResultDTO>();

        foreach (ContractEntity entity in Contracts)
        {
            resultContracts.Add(mapper.Map<ContractResultDTO>(entity));
        }

        return new Responce<IEnumerable<ContractResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultContracts
        };
    }

    public async Task<Responce<ContractResultDTO>> GetByIdAsync(long id)
    {
        ContractEntity existContract = await unitOfWork.contracts.GetByIdAsync(id);

        if (existContract is null)
            return new Responce<ContractResultDTO>
            {
                StatusCode = 404,
                Message = "This Contract was not found",
            };

        var resultContract = mapper.Map<ContractResultDTO>(existContract);

        return new Responce<ContractResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultContract
        };
    }
}
