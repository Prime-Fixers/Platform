using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Commands;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Services;

public interface ISubscriptionCommandService
{
    Task<Subscription?> Handle(UpgradePlanCommand command);
    Task<Subscription?> Handle(CreateSubscriptionCommand command);
    Task<bool> Handle(DeleteSubscriptionCommand command);
}