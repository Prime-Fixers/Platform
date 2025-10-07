using FrostLinkPlatform.API.WorkOrders.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.WorkOrders.Domain.Model.Commands;  

/// <summary>
/// Command to update the status of an existing WorkOrder.
/// </summary>
public record UpdateWorkOrderStatusCommand(
    int WorkOrderId,
    EWorkOrderStatus NewStatus
);