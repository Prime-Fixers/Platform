using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Shared.Domain.Repositories;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Repositories;

public interface IPaymentRepository : IBaseRepository<Payment>
{
    Task<Payment?> FindByStripeSessionIdAsync(string stripeSessionId);
    Task<IEnumerable<Payment>> FindByUserIdAsync(int userId);
}