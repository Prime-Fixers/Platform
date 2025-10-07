using FrostLinkPlatform.API.Analytics.Domain.Model.Entities;
using FrostLinkPlatform.API.Analytics.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.Analytics.Interfaces.REST.Transform;

/// <summary>
/// Assembles an EnergyReadingResource from an EnergyReading entity
/// </summary>
public static class EnergyReadingResourceFromEntityAssembler
{
    public static EnergyReadingResource ToResourceFromEntity(EnergyReading entity)
    {
        return new EnergyReadingResource(
            entity.Id,
            entity.EquipmentId,
            entity.Consumption,
            entity.Unit,
            entity.Timestamp,
            entity.Status.ToString()
        );
    }
}