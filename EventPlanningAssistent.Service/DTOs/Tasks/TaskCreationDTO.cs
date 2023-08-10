namespace EventPlanningAssistent.Service.DTOs.Tasks;

public class TaskCreationDTO
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
    public long EventId { get; set; }
}
