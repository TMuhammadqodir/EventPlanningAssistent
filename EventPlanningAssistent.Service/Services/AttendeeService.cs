using AutoMapper;
using EventPlanningAssistent.Data.IRepositories.Commons;
using EventPlanningAssistent.Data.Repositories.Commons;
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

    public Task<Responce<AttendeeResultDTO>> CreateAsync(AttendeeCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<AttendeeResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<AttendeeResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<AttendeeResultDTO>> UpdateAsync(AttendeeUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
