// See https://aka.ms/new-console-template for more information
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.DTOs.Ventors;
using EventPlanningAssistent.Service.Services;

//EventService eventService = new EventService();

/*eventService.CreateAsync(new EventCreationDTO() 
{     
    Name = "Test1",
    Date = DateTime.UtcNow,
    Location = "12345",
    Description = "Test1",
});*/
/*eventService.CreateAsync(new EventCreationDTO()
{
    Name = "Test2",
    Date = DateTime.UtcNow,
    Location = "12345",
    Description = "Test2"
}); eventService.CreateAsync(new EventCreationDTO()
{
    Name = "Test3",
    Date = DateTime.UtcNow,
    Location = "12345",
    Description = "Test3",
}); eventService.CreateAsync(new EventCreationDTO()
{
    Name = "Test4",
    Date = DateTime.UtcNow,
    Location = "12345",
    Description = "Test4",
}); eventService.CreateAsync(new EventCreationDTO()
{
    Name = "Test5",
    Date = DateTime.UtcNow,
    Location = "12345",
    Description = "Test5",
}); eventService.CreateAsync(new EventCreationDTO()
{
    Name = "Test6",
    Date = DateTime.UtcNow,
    Location = "12345",
    Description = "Test6",
});*/


VentorService ventorService = new VentorService();

await ventorService.CreateAsync(new VentorCreationDTO()
{
    FirstName = "test2",
    LastName = "test2",
    TelNumber = "234232"
}); await ventorService.CreateAsync(new VentorCreationDTO()
{
    FirstName = "test3",
    LastName = "test3",
    TelNumber = "2342332"
}); await ventorService.CreateAsync(new VentorCreationDTO()
{
    FirstName = "test4",
    LastName = "test4",
    TelNumber = "234542"
}); await ventorService.CreateAsync(new VentorCreationDTO()
{
    FirstName = "test5",
    LastName = "test5",
    TelNumber = "2311142"
});