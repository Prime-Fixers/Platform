using FrostLinkPlatform.API.Profiles.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.Profiles.Domain.Model.Queries;

public record GetProfileByEmailQuery(EmailAddress Email);