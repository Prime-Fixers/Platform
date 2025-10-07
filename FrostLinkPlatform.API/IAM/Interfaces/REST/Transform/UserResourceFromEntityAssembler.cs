using FrostLinkPlatform.API.IAM.Domain.Model.Aggregates;
using FrostLinkPlatform.API.IAM.Interfaces.REST.Resources;

namespace FrostLinkPlatform.API.IAM.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(user.Id, user.Username);
    }
}