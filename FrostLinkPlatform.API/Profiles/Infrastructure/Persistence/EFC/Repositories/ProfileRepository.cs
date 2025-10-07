using FrostLinkPlatform.API.Profiles.Domain.Model.Aggregates;
using FrostLinkPlatform.API.Profiles.Domain.Model.ValueObjects;
using FrostLinkPlatform.API.Profiles.Domain.Repositories;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace FrostLinkPlatform.API.Profiles.Infrastructure.Persistence.EFC.Repositories;

public class ProfileRepository(AppDbContext context)
: BaseRepository<Profile>(context), IProfileRepository
{
 public async Task<Profile?> FindProfileByEmailAsync(EmailAddress email)
 {
  return Context.Set<Profile>().FirstOrDefault(p => p.Email == email);
 }    
}