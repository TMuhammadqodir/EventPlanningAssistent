namespace EventPlanningAssistent.Service.DTOs.Attendees;

public class AttendeeCreationDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TelNumber { get; set; }
    public long TaskId { get; set; }
}
