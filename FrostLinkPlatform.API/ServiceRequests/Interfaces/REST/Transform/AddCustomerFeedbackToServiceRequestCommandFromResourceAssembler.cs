using FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;
using FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.ServiceRequests.Interfaces.REST.Transform;

public static class AddCustomerFeedbackToServiceRequestCommandFromResourceAssembler
{
    public static AddCustomerFeedbackToServiceRequestCommand ToCommandFromResource(int serviceRequestId, AddCustomerFeedbackToServiceRequestResource resource)
    {
        return new AddCustomerFeedbackToServiceRequestCommand(serviceRequestId, resource.Rating);
    }
}