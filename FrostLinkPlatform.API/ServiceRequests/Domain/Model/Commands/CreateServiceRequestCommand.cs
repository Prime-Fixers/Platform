namespace FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;

using FrostLinkPlatform.API.ServiceRequests.Domain.Model.ValueObjects;

public record CreateServiceRequestCommand(
    string Title,
    string Description,
    string IssueDetails,
    int ClientId,
    int CompanyId,
    int EquipmentId,
    EServiceType ServiceType, 
    int? ReportedByUserId,
    EPriority Priority,
    EUrgency Urgency,
    bool IsEmergency,
    DateTimeOffset? ScheduledDate,
    string TimeSlot,
    string ServiceAddress
);
