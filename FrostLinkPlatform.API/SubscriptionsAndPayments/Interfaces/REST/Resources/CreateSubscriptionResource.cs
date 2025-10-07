using System.ComponentModel.DataAnnotations;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Interfaces.REST.Resources;

public record CreateSubscriptionResource
{
    [Required(ErrorMessage = "Plan name is required")]
    public string PlanName { get; init; } = string.Empty;
    
    [Required(ErrorMessage = "Price is required")]
    [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0")]
    public decimal Price { get; init; }
    
    [Required(ErrorMessage = "Billing cycle is required")]
    public BillingCycle BillingCycle { get; init; }
    
    public int? MaxEquipment { get; init; }
    public int? MaxClients { get; init; }
    public List<string>? Features { get; init; }
}