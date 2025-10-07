using Cortex.Mediator;
using FrostLinkPlatform.API.bc_technicians.Domain.Events;
using FrostLinkPlatform.API.bc_technicians.Domain.Model.Commands;
using FrostLinkPlatform.API.bc_technicians.Domain.Model.Entities;
using FrostLinkPlatform.API.bc_technicians.Domain.Repositories;
using FrostLinkPlatform.API.bc_technicians.Domain.Services;
using FrostLinkPlatform.API.Shared.Domain.Repositories;

namespace FrostLinkPlatform.API.bc_technicians.Application.Internal.CommandServices;

public class TechnicianCommandService(ITechnicianRepository technicianRepository, IUnitOfWork unitOfWork , IMediator domainEventPublisher) 
    : ITechnicianCommandService
{

    public async Task<Technician?> Handle(CreateTechnicianCommand command)
    {
        var technician = new Technician(command);
        await technicianRepository.AddAsync(technician);
        await unitOfWork.CompleteAsync();
        
        await domainEventPublisher.PublishAsync(new TechnicianCreatedEvent(technician.Name, technician.Specialization, technician.Phone, technician.Email, technician.Availability,technician.CompanyId));
        return technician;
    }
}
