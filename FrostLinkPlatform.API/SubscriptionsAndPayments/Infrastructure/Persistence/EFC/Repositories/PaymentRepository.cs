using Microsoft.EntityFrameworkCore;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Repositories;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Infrastructure.Persistence.EFC.Repositories;

public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Payment?> FindByStripeSessionIdAsync(string stripeSessionId)
    {
        return await Context.Set<Payment>()
            .Where(p => EF.Property<string>(p, "StripeSessionId") == stripeSessionId)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Payment>> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Payment>()
            .Where(p => p.UserId == userId)
            .OrderByDescending(p => p.CreatedDate)
            .ToListAsync();
    }
}