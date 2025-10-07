using System.ComponentModel.DataAnnotations;
using FrostLinkPlatform.API.WorkOrders.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.WorkOrders.Interfaces.REST.Resources;

public class UpdateWorkOrderStatusResource
{
    [Required]
    public EWorkOrderStatus NewStatus { get; set; } 
}