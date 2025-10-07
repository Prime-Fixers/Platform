using FrostLinkPlatform.API.EquipmentManagement.Domain.Model.Aggregates;
using FrostLinkPlatform.API.EquipmentManagement.Domain.Repositories;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FrostLinkPlatform.API.EquipmentManagement.Infrastructure.Persistence.EFC.Repositories;

public class EquipmentRepository(AppDbContext context) : BaseRepository<Equipment>(context), IEquipmentRepository
{
    public async Task<IEnumerable<Equipment>> FindByOwnerIdAsync(int ownerId)
    {
        return await Context.Set<Equipment>()
            .Where(e => e.OwnerId == ownerId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Equipment>> FindByTypeAsync(string equipmentType)
    {
        return await Context.Set<Equipment>()
            .Where(e => e.Type.ToString().ToLower() == equipmentType.ToLower())
            .ToListAsync();
    }

    public async Task<IEnumerable<Equipment>> FindByStatusAsync(string status)
    {
        return await Context.Set<Equipment>()
            .Where(e => e.Status.ToString().ToLower() == status.ToLower())
            .ToListAsync();
    }

    public async Task<bool> ExistsBySerialNumberAsync(string serialNumber)
    {
        return await Context.Set<Equipment>()
            .AnyAsync(e => e.SerialNumber == serialNumber);
    }

    public async Task<bool> ExistsByCodeAsync(string code)
    {
        return await Context.Set<Equipment>()
            .AnyAsync(e => e.Code == code);
    }
}