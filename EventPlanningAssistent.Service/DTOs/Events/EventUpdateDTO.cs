namespace EventPlanningAssistent.Service.DTOs.Events;

public class EventUpdateDTO
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
}
