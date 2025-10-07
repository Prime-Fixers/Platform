using FrostLinkPlatform.API.IAM.Domain.Model.Commands;
using FrostLinkPlatform.API.IAM.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.IAM.Interfaces.REST.Transform;

public static class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.Username, resource.Password);
    }
}