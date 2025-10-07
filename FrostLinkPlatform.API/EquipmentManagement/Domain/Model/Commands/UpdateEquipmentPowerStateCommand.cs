namespace FrostLinkPlatform.API.EquipmentManagement.Domain.Model.Commands;

public record UpdateEquipmentPowerStateCommand(int EquipmentId, bool IsPoweredOn);