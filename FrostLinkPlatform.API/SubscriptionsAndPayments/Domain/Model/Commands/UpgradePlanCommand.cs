namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Commands;

public record UpgradePlanCommand(int UserId, int PlanId);