using EventPlanningAssistent.Domain.Commons;
using EventPlanningAssistent.Domain.Entities.Ventors;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlanningAssistent.Domain.Entities.Contracts;

[Table("Contracts")]
public class ContractEntity : Auditable
{
    public string ContractDeatails { get; set; }
    public long VentorId { get; set; }
    public VentorEntity Ventor { get; set; }
}
