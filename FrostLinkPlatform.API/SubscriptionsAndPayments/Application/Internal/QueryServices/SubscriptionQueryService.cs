using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Queries;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Repositories;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Services;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Application.Internal.QueryServices;

public class SubscriptionQueryService(ISubscriptionRepository subscriptionRepository) : ISubscriptionQueryService
{
    public async Task<Subscription?> Handle(GetSubscriptionByIdQuery query)
    {
        return await subscriptionRepository.FindByIdAsync(query.SubscriptionId);
    }

    public async Task<IEnumerable<Subscription>> Handle(GetPlansQuery query)
    {
        var plans = await subscriptionRepository.ListAsync();
        return query.UserType.ToLower() == "provider"
            ? plans.Where(p => p.MaxClients.HasValue)
            : plans.Where(p => p.MaxEquipment.HasValue);
    }
}