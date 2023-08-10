using EventPlanningAssistent.Domain.Commons;
using EventPlanningAssistent.Domain.Entities.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.Attendees;

[Table("Attendees")]
public class Attendee : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TelNumber { get; set; }
    public long TaskId { get; set; }
    public TaskEntity TaskEntity { get; set; }
}
