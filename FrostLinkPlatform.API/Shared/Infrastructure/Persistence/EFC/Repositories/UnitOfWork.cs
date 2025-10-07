using FrostLinkPlatform.API.Shared.Domain.Repositories;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    /// <inheritdoc />
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}