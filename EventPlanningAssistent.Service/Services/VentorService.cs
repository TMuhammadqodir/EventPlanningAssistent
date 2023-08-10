using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
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

    public Task<Responce<VentorResultDTO>> CreateAsync(VentorCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<VentorResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<VentorResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<VentorResultDTO>> UpdateAsync(VentorUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
