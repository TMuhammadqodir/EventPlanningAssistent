namespace EventPlanningAssistent.Service.DTOs.Tasks;

public class TaskResultDTO
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
    public long EventId { get; set; }
}
