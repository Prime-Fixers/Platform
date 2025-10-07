using FrostLinkPlatform.API.Analytics.Domain.Model.Commands;
using FrostLinkPlatform.API.Analytics.Domain.Model.Entities;

namespace FrostLinkPlatform.API.Analytics.Domain.Services;

/// <summary>
/// Command service interface for analytics operations
/// </summary>
public interface IAnalyticsCommandService
{
    Task<TemperatureReading?> Handle(RecordTemperatureReadingCommand command);
    Task<EnergyReading?> Handle(RecordEnergyReadingCommand command);
}