using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Service.DTOs.EventVentors;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;
using EventPlanningAssistent.Service.Mappers;

namespace EventPlanningAssistent.Service.Services;

public class EventVentorService : IEventVentorServise
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public EventVentorService()
    {
        unitOfWork = new UnitOfWork();

        mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
    }

    public Task<Responce<EventVentorResultDTO>> CreateAsync(EventVentorCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<EventVentorResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventVentorResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventVentorResultDTO>> UpdateAsync(EventVentorUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
