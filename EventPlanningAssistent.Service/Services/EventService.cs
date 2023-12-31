﻿using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.DTOs.Tasks;
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
        var temp = await unitOfWork.SaveAsync();

        Console.WriteLine(temp);

        EventResultDTO eventResult = mapper.Map<EventResultDTO>(entity);

        return new Responce<EventResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = eventResult
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        EventEntity existEvent = await unitOfWork.events.GetByIdAsync(id);

        if (existEvent is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This event was not found",
                Result = false
            };

        unitOfWork.events.Delete(existEvent);
        await unitOfWork.SaveAsync();

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Result = true
        };
    }

    public async Task<Responce<EventResultDTO>> UpdateAsync(EventUpdateDTO dto)
    {
        EventEntity existEvent = await unitOfWork.events.GetByIdAsync(dto.Id);

        if (existEvent is null)
            return new Responce<EventResultDTO>
            {
                StatusCode = 404,
                Message = "This event was not found",
            };

        var eventUpdate = mapper.Map(dto, existEvent);
        
        unitOfWork.events.Update(eventUpdate);
        await unitOfWork.SaveAsync();

        var resultEvent = mapper.Map<EventResultDTO>(eventUpdate);

        return new Responce<EventResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultEvent
        };
    }

    public async Task<Responce<IEnumerable<EventResultDTO>>> GetAllAysnc()
    {
        var events = unitOfWork.events.GetAll();

        var resultEvents = new List<EventResultDTO>();

        foreach(EventEntity entity in events)
        {
            resultEvents.Add(mapper.Map<EventResultDTO>(entity));
        }

        return new Responce<IEnumerable<EventResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultEvents
        };
    }

    public async Task<Responce<EventResultDTO>> GetByIdAsync(long id)
    {
        EventEntity existEvent = await unitOfWork.events.GetByIdAsync(id);

        if (existEvent is null)
            return new Responce<EventResultDTO>
            {
                StatusCode = 404,
                Message = "This event was not found",
            };

        var resultEvent = mapper.Map<EventResultDTO>(existEvent);

        return new Responce<EventResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultEvent
        };
    }

    public async Task<Responce<IEnumerable<TaskResultDTO>>> GetAllTaskOfEventAsync(long id)
    {
        var tasks = unitOfWork.events.GetAllTasksOfEvent(id);

        var resultTasks = new List<TaskResultDTO>();

        foreach (var task in tasks)
        {
            resultTasks.Add(mapper.Map<TaskResultDTO>(task));
        }

        return new Responce<IEnumerable<TaskResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultTasks
        };
    }
}
