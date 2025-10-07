using FrostLinkPlatform.API.Analytics.Domain.Model.Commands;
using FrostLinkPlatform.API.Analytics.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.Analytics.Interfaces.REST.Transform;

/// <summary>
/// Assembles a RecordEnergyReadingCommand from a CreateEnergyReadingResource
/// </summary>
public static class CreateEnergyReadingCommandFromResourceAssembler
{
    public static RecordEnergyReadingCommand ToCommandFromResource(CreateEnergyReadingResource resource)
    {
        return new RecordEnergyReadingCommand(
            resource.EquipmentId,
            resource.Consumption,
            resource.Unit
        );
    }
}