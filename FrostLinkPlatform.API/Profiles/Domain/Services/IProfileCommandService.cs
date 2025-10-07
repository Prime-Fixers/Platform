using FrostLinkPlatform.API.Profiles.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Profiles.Domain.Model.Commands;

namespace FrostLinkPlatform.API.Profiles.Domain.Services;

public interface IProfileCommandService
{
    Task<Profile?> Handle(CreateProfileCommand command);
}