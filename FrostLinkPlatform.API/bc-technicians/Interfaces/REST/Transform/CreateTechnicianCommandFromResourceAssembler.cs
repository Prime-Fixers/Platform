using FrostLinkPlatform.API.bc_technicians.Domain.Model.Commands;
using FrostLinkPlatform.API.bc_technicians.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.bc_technicians.Interfaces.REST.Transform;

public static class CreateTechnicianCommandFromResourceAssembler
{
    public static CreateTechnicianCommand ToCommandFromResource(
        CreateTechnicianResource resource)
    {
        return new CreateTechnicianCommand(
            resource.Name,
            resource.Specialization,
            resource.Phone,
            resource.Email,
            resource.Availability,
            resource.CompanyId
        );
    }
}