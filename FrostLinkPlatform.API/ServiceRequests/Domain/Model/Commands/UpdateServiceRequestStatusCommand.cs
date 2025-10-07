using FrostLinkPlatform.API.ServiceRequests.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;

public record UpdateServiceRequestStatusCommand(int ServiceRequestId, EServiceRequestStatus NewStatus);
