using FrostLinkPlatform.API.ServiceRequests.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.ServiceRequests.Domain.Model.Queries;

public record GetServiceRequestsByStatusQuery(EServiceRequestStatus Status);
