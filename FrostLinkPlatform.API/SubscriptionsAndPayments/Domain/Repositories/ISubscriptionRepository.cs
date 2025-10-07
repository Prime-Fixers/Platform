using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Shared.Domain.Repositories;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Repositories;

public interface ISubscriptionRepository : IBaseRepository<Subscription>
{
    Task<Subscription?> FindByUserIdAsync(int userId);
}