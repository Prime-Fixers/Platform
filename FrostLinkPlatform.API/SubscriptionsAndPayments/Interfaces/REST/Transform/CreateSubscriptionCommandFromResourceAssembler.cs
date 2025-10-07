using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Commands;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Interfaces.REST.Transform;

public static class CreateSubscriptionCommandFromResourceAssembler
{
    public static CreateSubscriptionCommand ToCommandFromResource(CreateSubscriptionResource resource)
    {
        return new CreateSubscriptionCommand(
            resource.PlanName,
            resource.Price,
            resource.BillingCycle,
            resource.MaxEquipment,
            resource.MaxClients,
            resource.Features
        );
    }
}