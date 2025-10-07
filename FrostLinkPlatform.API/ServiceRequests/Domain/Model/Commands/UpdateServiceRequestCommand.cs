namespace FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;

using FrostLinkPlatform.API.ServiceRequests.Domain.Model.ValueObjects;

public record UpdateServiceRequestCommand(
    int Id,
    string Title,
    string Description,
    string IssueDetails,
    EServiceRequestStatus Status,
    EPriority Priority,
    EUrgency Urgency,
    bool IsEmergency,
    EServiceType ServiceType, 
    int? AssignedTechnicianId,
    DateTimeOffset? ScheduledDate,
    string TimeSlot,
    string ServiceAddress
);
