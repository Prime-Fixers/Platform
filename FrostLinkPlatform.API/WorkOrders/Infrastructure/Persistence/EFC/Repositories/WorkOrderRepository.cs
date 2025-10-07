using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories; 
using FrostLinkPlatform.API.WorkOrders.Domain.Model.Aggregates;
using FrostLinkPlatform.API.WorkOrders.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FrostLinkPlatform.API.WorkOrders.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// EF Core implementation of IWorkOrderRepository using BaseRepository.
/// </summary>

public class WorkOrderRepository(AppDbContext context) : BaseRepository<WorkOrder>(context), IWorkOrderRepository
{

    public async Task<WorkOrder?> FindByWorkOrderNumberAsync(string workOrderNumber)
    {
        return await Context.Set<WorkOrder>().FirstOrDefaultAsync(wo => wo.WorkOrderNumber == workOrderNumber);
    }

    public async Task<WorkOrder?> FindByServiceRequestIdAsync(int serviceRequestId)
    {
        return await Context.Set<WorkOrder>().FirstOrDefaultAsync(wo => wo.ServiceRequestId == serviceRequestId);
    }
}