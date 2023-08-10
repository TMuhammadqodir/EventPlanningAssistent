using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;
using EventPlanningAssistent.Service.Mappers;

namespace EventPlanningAssistent.Service.Services;

public class EventService : IEventService
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public EventService()
    {
        unitOfWork = new UnitOfWork();

        mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
    }

    public async Task<Responce<EventResultDTO>> CreateAsync(EventCreationDTO dto)
    {
        EventEntity entity = mapper.Map<EventEntity>(dto);

        await unitOfWork.events.CreateAsync(entity);
        await unitOfWork.SaveAsync();

        EventResultDTO eventResult = mapper.Map<EventResultDTO>(dto);

        return new Responce<EventResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = eventResult
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        EventEntity eventEntity = await unitOfWork.events.GetById(id);
    }

    public Task<Responce<IEnumerable<EventResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<EventResultDTO>> UpdateAsync(EventUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
