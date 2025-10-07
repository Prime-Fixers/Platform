using FrostLinkPlatform.API.WorkOrders.Domain.Model.Commands;
using FrostLinkPlatform.API.WorkOrders.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.WorkOrders.Interfaces.REST.Transform;

/// <summary>
/// Assembles an AddWorkOrderCustomerFeedbackCommand from an AddCustomerFeedbackResource.
/// </summary>
public static class AddWorkOrderCustomerFeedbackCommandFromResourceAssembler
{
    public static AddWorkOrderCustomerFeedbackCommand ToCommandFromResource(int workOrderId, AddCustomerFeedbackResource resource)
    {
        return new AddWorkOrderCustomerFeedbackCommand(
            workOrderId,
            resource.Rating
            );
    }
}