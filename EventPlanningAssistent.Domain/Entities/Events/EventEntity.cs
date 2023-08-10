using EventPlanningAssistent.Domain.Entities.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.Events;

[Table("Events")]
public class EventEntity
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    ICollection<TaskEntity> Tasks { get; set; }
}
