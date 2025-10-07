using FrostLinkPlatform.API.WorkOrders.Domain.Model.Commands;
using FrostLinkPlatform.API.WorkOrders.Domain.Model.ValueObjects;
using FrostLinkPlatform.API.WorkOrders.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.WorkOrders.Interfaces.REST.Transform;

public static class UpdateWorkOrderStatusCommandFromResourceAssembler
{
    public static UpdateWorkOrderStatusCommand ToCommandFromResource(int workOrderId, UpdateWorkOrderStatusResource resource)
    {
        return new UpdateWorkOrderStatusCommand(workOrderId, resource.NewStatus);
    }
}