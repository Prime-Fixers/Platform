namespace FrostLinkPlatform.API.ServiceRequests.Domain.Repositories;

using FrostLinkPlatform.API.ServiceRequests.Domain.Model.Aggregates;
using FrostLinkPlatform.API.ServiceRequests.Domain.Model.ValueObjects; 
using FrostLinkPlatform.API.Shared.Domain.Repositories; 

public interface IServiceRequestRepository : IBaseRepository<ServiceRequest>
{
    Task<IEnumerable<ServiceRequest>> FindByStatusAsync(EServiceRequestStatus status);
    Task<IEnumerable<ServiceRequest>> FindByEquipmentIdAsync(int equipmentId);
    Task<IEnumerable<ServiceRequest>> FindByAssignedTechnicianIdAsync(int technicianId);
    Task<bool> ExistsByOrderNumberAsync(string orderNumber);
}
