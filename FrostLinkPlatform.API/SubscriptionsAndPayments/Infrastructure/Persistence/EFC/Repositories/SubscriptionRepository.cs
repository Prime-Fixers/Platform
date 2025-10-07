using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Repositories;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Infrastructure.Persistence.EFC.Repositories;

public class SubscriptionRepository : BaseRepository<Subscription>, ISubscriptionRepository
{
    public SubscriptionRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Subscription?> FindByUserIdAsync(int userId)
    {
        // For now, it returns null to the users that do not have an active subscription
        // This will allow the pay flow to work correctly
        return null;
        
        
        // return await Context.Set<Subscription>().FirstOrDefaultAsync(s => s.Id == 1);
    }
}