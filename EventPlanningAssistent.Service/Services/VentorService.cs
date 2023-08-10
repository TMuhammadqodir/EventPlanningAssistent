using EventPlanningAssistent.Service.DTOs.Ventors;
using EventPlanningAssistent.Service.Helpers;
using EventPlanningAssistent.Service.IServices;

namespace EventPlanningAssistent.Service.Services;

public class VentorService : IVentorService
{
    public Task<Responce<VentorResultDTO>> CreateAsync(VentorCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<IEnumerable<VentorResultDTO>>> GetAllAysnc()
    {
        throw new NotImplementedException();
    }

    public Task<Responce<VentorResultDTO>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Responce<VentorResultDTO>> UpdateAsync(VentorUpdateDTO dto)
    {
        throw new NotImplementedException();
    }
}
