using FrostLinkPlatform.API.ServiceRequests.Domain.Model.Aggregates;
using FrostLinkPlatform.API.ServiceRequests.Domain.Model.Queries;
using FrostLinkPlatform.API.ServiceRequests.Domain.Repositories;
using FrostLinkPlatform.API.ServiceRequests.Domain.Services;

namespace FrostLinkPlatform.API.ServiceRequests.Application.Internal.QueryServices;


public class ServiceRequestQueryService(IServiceRequestRepository serviceRequestRepository) : IServiceRequestQueryService
{
    public async Task<ServiceRequest?> Handle(GetServiceRequestByIdQuery query)
    {
        return await serviceRequestRepository.FindByIdAsync(query.ServiceRequestId);
    }

    public async Task<IEnumerable<ServiceRequest>> Handle(GetAllServiceRequestsQuery query)
    {
        return await serviceRequestRepository.ListAsync();
    }

    public async Task<IEnumerable<ServiceRequest>> Handle(GetServiceRequestsByStatusQuery query)
    {
        return await serviceRequestRepository.FindByStatusAsync(query.Status);
    }

    public async Task<IEnumerable<ServiceRequest>> Handle(GetServiceRequestsByEquipmentIdQuery query)
    {
        return await serviceRequestRepository.FindByEquipmentIdAsync(query.EquipmentId);
    }
    
}