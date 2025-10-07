using FrostLinkPlatform.API.Profiles.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Profiles.Domain.Model.ValueObjects;
using FrostLinkPlatform.API.Shared.Domain.Repositories;

namespace FrostLinkPlatform.API.Profiles.Domain.Repositories;

public interface IProfileRepository : IBaseRepository<Profile>
{
    Task<Profile?> FindProfileByEmailAsync(EmailAddress email);
}
