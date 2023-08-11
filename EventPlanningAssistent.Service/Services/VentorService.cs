using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Attendees;
using EventPlanningAssistent.Domain.Entities.Ventors;
using EventPlanningAssistent.Service.DTOs.Attendees;
using EventPlanningAssistent.Service.DTOs.Contracts;
using EventPlanningAssistent.Service.DTOs.Ventors;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;
using EventPlanningAssistent.Service.Mappers;

namespace EventPlanningAssistent.Service.Services;

public class VentorService : IVentorService
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public VentorService()
    {
        unitOfWork = new UnitOfWork();

        mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
    }

    public async Task<Responce<VentorResultDTO>> CreateAsync(VentorCreationDTO dto)
    {
        var existVentor = await unitOfWork.ventors.GetByTelNumberAsync(dto.TelNumber);

        if (existVentor is not null)
            return new Responce<VentorResultDTO>
            {
                StatusCode = 403,
                Message = "This ventor already exists",
            };

        var entity = mapper.Map<VentorEntity>(dto);

        await unitOfWork.ventors.CreateAsync(entity);
        await unitOfWork.SaveAsync();

        var resultVentor = mapper.Map<VentorResultDTO>(entity);

        return new Responce<VentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultVentor
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        VentorEntity existVentor = await unitOfWork.ventors.GetByIdAsync(id);

        if (existVentor is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This Ventor was not found",
                Result = false
            };

        unitOfWork.ventors.Delete(existVentor);
        await unitOfWork.SaveAsync();

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Result = true
        };
    }

    public async Task<Responce<VentorResultDTO>> UpdateAsync(VentorUpdateDTO dto)
    {
        VentorEntity existVentor = await unitOfWork.ventors.GetByIdAsync(dto.Id);

        if (existVentor is null)
            return new Responce<VentorResultDTO>
            {
                StatusCode = 404,
                Message = "This Ventor was not found",
            };

        var VentorUpdate = mapper.Map(dto, existVentor);

        unitOfWork.ventors.Update(VentorUpdate);
        await unitOfWork.SaveAsync();

        var resultVentor = mapper.Map<VentorResultDTO>(VentorUpdate);

        return new Responce<VentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultVentor
        };
    }

    public async Task<Responce<IEnumerable<VentorResultDTO>>> GetAllAysnc()
    {
        var Ventors = unitOfWork.ventors.GetAll();

        var resultVentors = new List<VentorResultDTO>();

        foreach (VentorEntity entity in Ventors)
        {
            resultVentors.Add(mapper.Map<VentorResultDTO>(entity));
        }

        return new Responce<IEnumerable<VentorResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultVentors
        };
    }

    public async Task<Responce<VentorResultDTO>> GetByIdAsync(long id)
    {
        VentorEntity existVentor = await unitOfWork.ventors.GetByIdAsync(id);

        if (existVentor is null)
            return new Responce<VentorResultDTO>
            {
                StatusCode = 404,
                Message = "This Ventor was not found",
            };

        var resultVentor = mapper.Map<VentorResultDTO>(existVentor);

        return new Responce<VentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultVentor
        };
    }

    public async Task<Responce<VentorResultDTO>> GetByTelNumberAsync(string telNumber)
    {
        VentorEntity existVentor = await unitOfWork.ventors.GetByTelNumberAsync(telNumber);

        if (existVentor is null)
            return new Responce<VentorResultDTO>
            {
                StatusCode = 404,
                Message = "This Ventor was not found",
            };

        var resultVentor = mapper.Map<VentorResultDTO>(existVentor);

        return new Responce<VentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultVentor
        };
    }

    public async Task<Responce<IEnumerable<VentorResultDTO>>> SearchByNameAsync(string name)
    {
        var ventors = unitOfWork.ventors.SeachByName(name);

        var resultVentors = new List<VentorResultDTO>();

        foreach (var item in ventors)
        {
            resultVentors.Add(mapper.Map<VentorResultDTO>(item));
        }

        return new Responce<IEnumerable<VentorResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultVentors
        };
    }

    public async Task<Responce<IEnumerable<ContractResultDTO>>> GetAllContractOfVentorAsync(long id)
    {
        var contracts = unitOfWork.ventors.GetAllContractOfVentor(id);

        var resultContracts = new List<ContractResultDTO>();

        foreach(var contract in contracts)
        {
            resultContracts.Add(mapper.Map<ContractResultDTO>(contract));
        }

        return new Responce<IEnumerable<ContractResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultContracts
        };
    }
}
