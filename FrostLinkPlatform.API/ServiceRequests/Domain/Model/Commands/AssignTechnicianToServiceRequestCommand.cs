namespace FrostLinkPlatform.API.ServiceRequests.Domain.Model.Commands;

public record AssignTechnicianToServiceRequestCommand(int ServiceRequestId, int TechnicianId);
