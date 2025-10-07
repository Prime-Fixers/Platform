namespace FrostLinkPlatform.API.Analytics.Domain.Model.Commands;

public record RecordTemperatureReadingCommand(
    int EquipmentId,
    decimal Temperature,
    DateTimeOffset? Timestamp = null
);