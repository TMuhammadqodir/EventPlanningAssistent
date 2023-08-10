using EventPlanningAssistent.Domain.Commons;
using EventPlanningAssistent.Domain.Entities.Attendees;
using EventPlanningAssistent.Domain.Entities.Events;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.Tasks;

[Table("Tasks")]
public class TaskEntity : Auditable
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
    public long EventId { get; set; }
    public EventEntity Event { get; set; }
    public ICollection<AttendeeEntity> attendees { get; set; }
}
