using FrostLinkPlatform.API.bc_technicians.Domain.Model.Commands;
using FrostLinkPlatform.API.bc_technicians.Domain.Model.Entities;

namespace FrostLinkPlatform.API.bc_technicians.Domain.Services;

public interface ITechnicianCommandService
{
    Task<Technician?> Handle(CreateTechnicianCommand command);
}