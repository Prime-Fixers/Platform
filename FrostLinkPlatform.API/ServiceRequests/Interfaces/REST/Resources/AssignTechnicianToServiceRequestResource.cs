using System.ComponentModel.DataAnnotations;

namespace FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Resources;

public class AssignTechnicianToServiceRequestResource
{
    [Required]
    public int TechnicianId { get; set; }
}