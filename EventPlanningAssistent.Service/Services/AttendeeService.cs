using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
using EventPlanningAssistent.Domain.Entities.Attendees;
using EventPlanningAssistent.Domain.Entities.Tasks;
using EventPlanningAssistent.Service.DTOs.Attendees;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;
using EventPlanningAssistent.Service.Mappers;

namespace EventPlanningAssistent.Service.Services;

public class AttendeeService : IAttendeeService
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public AttendeeService()
    {
        unitOfWork = new UnitOfWork();

        mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
    }

    public async Task<Responce<AttendeeResultDTO>> CreateAsync(AttendeeCreationDTO dto)
    {
        TaskEntity existTask = await unitOfWork.tasks.GetByIdAsync(dto.TaskId);

        if (existTask is null)
            return new Responce<AttendeeResultDTO>
            {
                StatusCode = 404,
                Message = "This TaskId was not found",
            };

        AttendeeEntity existAttendee = await unitOfWork.attendees.GetByTelNumberAsync(dto.TelNumber);

        if (existAttendee is null)
            return new Responce<AttendeeResultDTO>
            {
                StatusCode = 403,
                Message = "This Attendee already exists"
            };

        AttendeeEntity entity = mapper.Map<AttendeeEntity>(dto);

        await unitOfWork.attendees.CreateAsync(entity);
        await unitOfWork.SaveAsync();

        AttendeeResultDTO AttendeeResult = mapper.Map<AttendeeResultDTO>(dto);

        return new Responce<AttendeeResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = AttendeeResult
        };
    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        AttendeeEntity existAttendee = await unitOfWork.attendees.GetByIdAsync(id);

        if (existAttendee is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This Attendee was not found",
                Result = false
            };

        unitOfWork.attendees.Delete(existAttendee);
        await unitOfWork.SaveAsync();

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Result = true
        };
    }

    public async Task<Responce<AttendeeResultDTO>> UpdateAsync(AttendeeUpdateDTO dto)
    {
        AttendeeEntity existAttendee = await unitOfWork.attendees.GetByIdAsync(dto.Id);

        if (existAttendee is null)
            return new Responce<AttendeeResultDTO>
            {
                StatusCode = 404,
                Message = "This Attendee was not found",
            };

        var AttendeeUpdate = mapper.Map(dto, existAttendee);

        unitOfWork.attendees.Update(AttendeeUpdate);
        await unitOfWork.SaveAsync();

        var resultAttendee = mapper.Map<AttendeeResultDTO>(AttendeeUpdate);

        return new Responce<AttendeeResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultAttendee
        };
    }

    public async Task<Responce<IEnumerable<AttendeeResultDTO>>> GetAllAysnc()
    {
        var Attendees = unitOfWork.attendees.GetAll();

        var resultAttendees = new List<AttendeeResultDTO>();

        foreach (AttendeeEntity entity in Attendees)
        {
            resultAttendees.Add(mapper.Map<AttendeeResultDTO>(entity));
        }

        return new Responce<IEnumerable<AttendeeResultDTO>>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultAttendees
        };
    }

    public async Task<Responce<AttendeeResultDTO>> GetByIdAsync(long id)
    {
        AttendeeEntity existAttendee = await unitOfWork.attendees.GetByIdAsync(id);

        if (existAttendee is null)
            return new Responce<AttendeeResultDTO>
            {
                StatusCode = 404,
                Message = "This Attendee was not found",
            };

        var resultAttendee = mapper.Map<AttendeeResultDTO>(existAttendee);

        return new Responce<AttendeeResultDTO>
        {
            StatusCode = 200,
            Message = "Success",
            Result = resultAttendee
        };
    }
}
