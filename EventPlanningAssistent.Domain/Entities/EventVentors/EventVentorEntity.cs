using EventPlanningAssistent.Domain.Commons;
using EventPlanningAssistent.Domain.Entities.Events;
using EventPlanningAssistent.Domain.Entities.Ventors;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.EventVentors;

[Table("EventVentors")]
public class EventVentorEntity : Auditable
{
    public long EventId { get; set; }
    public EventEntity Event { get; set; }
    public long VentorId { get; set; }  
    public VentorEntity Ventor { get; set; }
}
