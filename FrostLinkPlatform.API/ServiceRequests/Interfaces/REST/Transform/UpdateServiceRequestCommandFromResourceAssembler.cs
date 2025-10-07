using FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;
using FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Transform;

public static class UpdateServiceRequestCommandFromResourceAssembler
{
    public static UpdateServiceRequestCommand ToCommandFromResource(int id, UpdateServiceRequestResource resource)
    {
        return new UpdateServiceRequestCommand(
            id,
            resource.Title,
            resource.Description,
            resource.IssueDetails,
            resource.Status,       
            resource.Priority,     
            resource.Urgency,     
            resource.IsEmergency,
            resource.ServiceType,  
            resource.AssignedTechnicianId,
            resource.ScheduledDate,
            resource.TimeSlot,
            resource.ServiceAddress
        );
    }
}