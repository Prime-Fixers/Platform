using FrostLinkPlatform.API.EquipmentManagement.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Shared.Domain.Repositories;

namespace FrostLinkPlatform.API.EquipmentManagement.Domain.Repositories;

/// <summary>
/// Defines the contract for data access operations for Equipment aggregate.
/// </summary>
public interface IEquipmentRepository : IBaseRepository<Equipment>
{
    Task<IEnumerable<Equipment>> FindByOwnerIdAsync(int ownerId);
    Task<IEnumerable<Equipment>> FindByTypeAsync(string equipmentType);
    Task<IEnumerable<Equipment>> FindByStatusAsync(string status);
    Task<bool> ExistsBySerialNumberAsync(string serialNumber);
    Task<bool> ExistsByCodeAsync(string code);
}