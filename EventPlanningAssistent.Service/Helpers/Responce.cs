namespace EventPlanningAssistent.Service.Helpers;

public class Responce<T>
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public T Result { get; set; }
}
