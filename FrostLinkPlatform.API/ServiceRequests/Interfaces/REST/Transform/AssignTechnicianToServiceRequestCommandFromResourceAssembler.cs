using FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;
using FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Transform;

public static class AssignTechnicianToServiceRequestCommandFromResourceAssembler
{
    public static AssignTechnicianToServiceRequestCommand ToCommandFromResource(int serviceRequestId, AssignTechnicianToServiceRequestResource resource)
    {
        return new AssignTechnicianToServiceRequestCommand(serviceRequestId, resource.TechnicianId);
    }
}