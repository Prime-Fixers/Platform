using FrostLinkPlatform.API.Profiles.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Profiles.Domain.Model.Queries;

namespace FrostLinkPlatform.API.Profiles.Domain.Services;

public interface IProfileQueryService
{
    Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query);
    Task<Profile?> Handle(GetProfileByEmailQuery query);
    Task<Profile?> Handle(GetProfileByIdQuery query);
}