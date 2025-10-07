using FrostLinkPlatform.API.Analytics.Domain.Model.Commands;
using FrostLinkPlatform.API.Analytics.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.Analytics.Interfaces.REST.Transform;

/// <summary>
/// Assembles a RecordTemperatureReadingCommand from a CreateTemperatureReadingResource
/// </summary>
public static class CreateTemperatureReadingCommandFromResourceAssembler
{
    public static RecordTemperatureReadingCommand ToCommandFromResource(CreateTemperatureReadingResource resource)
    {
        return new RecordTemperatureReadingCommand(
            resource.EquipmentId,
            resource.Temperature,
            resource.Timestamp
        );
    }
}