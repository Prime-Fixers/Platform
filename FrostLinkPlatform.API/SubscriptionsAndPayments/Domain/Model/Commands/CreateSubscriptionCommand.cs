using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Commands;

public record CreateSubscriptionCommand(
    string PlanName,
    decimal Price,
    BillingCycle BillingCycle,
    int? MaxEquipment,
    int? MaxClients,
    List<string>? Features
);