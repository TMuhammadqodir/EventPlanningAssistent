using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.EventVentors;
using EventPlanningAssistent.Domain.Entities.Ventors;
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.DTOs.EventVentors;
using EventPlanningAssistent.Service.DTOs.Ventors;
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

    public async Task<Responce<EventVentorResultDTO>> CreateAsync(EventVentorCreationDTO dto)
    {
        EventEntity existEvent = await unitOfWork.events.GetByIdAsync(dto.EventId);

        if (existEvent is null)
            return new Responce<EventVentorResultDTO>
            {
                StatusCode = 404,
                Message = "This EventId was not found",
            };

        VentorEntity existVentor = await unitOfWork.ventors.GetByIdAsync(dto.VentorId);

        if (existVentor is null)
            return new Responce<EventVentorResultDTO>
            {
                StatusCode = 404,
                Message = "This VentorId was not found",
            };

        EventVentorEntity entity = mapper.Map<EventVentorEntity>(dto);

        await unitOfWork.eventVentors.CreateAsync(entity);
        await unitOfWork.SaveAsync();

        EventVentorResultDTO EventVentorResult = mapper.Map<EventVentorResultDTO>(dto);

        return new Responce<EventVentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = EventVentorResult
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        EventVentorEntity existEventVentor = await unitOfWork.eventVentors.GetByIdAsync(id);

        if (existEventVentor is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This EventVentor was not found",
                Result = false
            };

        unitOfWork.eventVentors.Delete(existEventVentor);
        await unitOfWork.SaveAsync();

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Result = true
        };
    }

    public async Task<Responce<EventVentorResultDTO>> UpdateAsync(EventVentorUpdateDTO dto)
    {
        EventVentorEntity existEventVentor = await unitOfWork.eventVentors.GetByIdAsync(dto.Id);

        if (existEventVentor is null)
            return new Responce<EventVentorResultDTO>
            {
                StatusCode = 404,
                Message = "This EventVentor was not found",
            };

        var EventVentorUpdate = mapper.Map(dto, existEventVentor);

        unitOfWork.eventVentors.Update(EventVentorUpdate);
        await unitOfWork.SaveAsync();

        var resultEventVentor = mapper.Map<EventVentorResultDTO>(EventVentorUpdate);

        return new Responce<EventVentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultEventVentor
        };
    }

    public async Task<Responce<IEnumerable<EventVentorResultDTO>>> GetAllAysnc()
    {
        var EventVentors = unitOfWork.eventVentors.GetAll();

        var resultEventVentors = new List<EventVentorResultDTO>();

        foreach (EventVentorEntity entity in EventVentors)
        {
            resultEventVentors.Add(mapper.Map<EventVentorResultDTO>(entity));
        }

        return new Responce<IEnumerable<EventVentorResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultEventVentors
        };
    }

    public async Task<Responce<EventVentorResultDTO>> GetByIdAsync(long id)
    {
        EventVentorEntity existEventVentor = await unitOfWork.eventVentors.GetByIdAsync(id);

        if (existEventVentor is null)
            return new Responce<EventVentorResultDTO>
            {
                StatusCode = 404,
                Message = "This EventVentor was not found",
            };

        var resultEventVentor = mapper.Map<EventVentorResultDTO>(existEventVentor);

        return new Responce<EventVentorResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultEventVentor
        };
    }

    public async Task<Responce<IEnumerable<EventResultDTO>>> GetAllEventOfVentorAsync(long ventorId)
    {
        var eventVentors = unitOfWork.eventVentors.GetAllByVentorId(ventorId);

        if (eventVentors is null)
            return new Responce<IEnumerable<EventResultDTO>> 
            {
                StatusCode= 200,
                Message = "Success", 
            };

        var eventResults = new List<EventResultDTO>();

        foreach(var item in eventVentors)
        {
            var temp = await unitOfWork.events.GetByIdAsync(item.EventId);

            var eventResult = mapper.Map<EventResultDTO>(temp);

            eventResults.Add(eventResult);
        }

        return new Responce<IEnumerable<EventResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = eventResults
        };
    }

    public async Task<Responce<IEnumerable<VentorResultDTO>>> GetAllVentorOfEventAsync(long eventId)
    {
        var eventVentors = unitOfWork.eventVentors.GetAllByEventId(eventId);

        if (eventVentors is null)
            return new Responce<IEnumerable<VentorResultDTO>>
            {
                StatusCode = 200,
                Message = "Success",
            };

        var ventorResults = new List<VentorResultDTO>();

        foreach (var item in eventVentors)
        {
            var temp = await unitOfWork.ventors.GetByIdAsync(item.EventId);

            var ventorResult = mapper.Map<VentorResultDTO>(temp);

            ventorResults.Add(ventorResult);
        }

        return new Responce<IEnumerable<VentorResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = ventorResults
        };
    }
}
