// See https://aka.ms/new-console-template for more information
using EventPlanningAssistent.Service.DTOs.Events;
using EventPlanningAssistent.Service.DTOs.EventVentors;
using EventPlanningAssistent.Service.DTOs.Ventors;
using EventPlanningAssistent.Service.Services;

EventVentorService eventVentorService = new EventVentorService();

var temp = await eventVentorService.GetAllEventOfVentorAsync(3);

foreach(var temp2 in temp.Result)
{
    Console.WriteLine(temp2.Name);
}   