using FrostLinkPlatform.API.ServiceRequests.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Resources;

public record UpdateServiceRequestResource(
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