using AutoMapper;
using EventPlanningAssistent.Domain.Entities.Attendees;
using EventPlanningAssistent.Domain.Entities.Contracts;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.EventVentors;
using EventPlanningAssistent.Domain.Entities.Tasks;
using EventPlanningAssistent.Domain.Entities.Ventors;
using EventPlanningAssistent.Service.DTOs.Attendees;
using EventPlanningAssistent.Service.DTOs.Contracts;
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.DTOs.EventVentors;
using EventPlanningAssistent.Service.DTOs.Tasks;
using EventPlanningAssistent.Service.DTOs.Ventors;

namespace EventPlanningAssistent.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<AttendeeEntity, AttendeeCreationDTO>().ReverseMap();
        CreateMap<AttendeeEntity, AttendeeUpdateDTO>().ReverseMap();
        CreateMap<AttendeeEntity, AttendeeResultDTO>().ReverseMap();

        CreateMap<ContractEntity, ContractCreationDTO>().ReverseMap();
        CreateMap<ContractEntity, ContractUpdateDTO>().ReverseMap();
        CreateMap<ContractEntity, ContractResultDTO>().ReverseMap();

        CreateMap<EventEntity, EventCreationDTO>().ReverseMap();
        CreateMap<EventEntity, EventUpdateDTO>().ReverseMap();
        CreateMap<EventEntity, EventResultDTO>().ReverseMap();

        CreateMap<EventVentorEntity, EventVentorCreationDTO>().ReverseMap();
        CreateMap<EventVentorEntity, EventVentorUpdateDTO>().ReverseMap();
        CreateMap<EventVentorEntity, EventVentorResultDTO>().ReverseMap();

        CreateMap<TaskEntity, TaskCreationDTO>().ReverseMap();
        CreateMap<TaskEntity, TaskUpdateDTO>().ReverseMap();
        CreateMap<TaskEntity, TaskResultDTO>().ReverseMap();

        CreateMap<VentorEntity, VentorCreationDTO>().ReverseMap();
        CreateMap<VentorEntity, VentorUpdateDTO>().ReverseMap();
        CreateMap<VentorEntity, VentorResultDTO>().ReverseMap();
    }
}
