using System.ComponentModel.DataAnnotations;

namespace FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Resources;

public class AddCustomerFeedbackToServiceRequestResource
{
    [Required]
    [Range(1, 5)] 
    public int Rating { get; set; }
}