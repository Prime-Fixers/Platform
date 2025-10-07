using FrostLinkPlatform.API.WorkOrders.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Shared.Domain.Repositories; 

namespace FrostLinkPlatform.API.WorkOrders.Domain.Repositories;

/// <summary>
/// Defines the contract for data access operations for WorkOrder aggregate.
/// </summary>
public interface IWorkOrderRepository : IBaseRepository<WorkOrder> 
{
    Task<WorkOrder?> FindByWorkOrderNumberAsync(string workOrderNumber);
    Task<WorkOrder?> FindByServiceRequestIdAsync(int serviceRequestId);
}