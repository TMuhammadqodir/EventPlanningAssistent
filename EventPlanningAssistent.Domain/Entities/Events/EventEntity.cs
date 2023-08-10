using EventPlanningAssistent.Domain.Commons;
using EventPlanningAssistent.Domain.Entities.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.Events;

[Table("Events")]
public class EventEntity : Auditable
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public ICollection<TaskEntity> Tasks { get; set; }
}
