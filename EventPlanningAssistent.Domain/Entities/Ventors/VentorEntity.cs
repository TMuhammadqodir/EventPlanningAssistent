using EventPlanningAssistent.Domain.Commons;
using EventPlanningAssistent.Domain.Entities.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.Ventors;

[Table("Ventors")]
public class VentorEntity : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TelNumber { get; set; }
    public ICollection<ContractEntity> contracts { get; set; }
}
