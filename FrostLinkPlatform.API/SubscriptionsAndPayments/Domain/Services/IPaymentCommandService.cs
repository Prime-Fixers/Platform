using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Aggregates;
using FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Model.Commands;

namespace FrostLinkPlatform.API.SubscriptionsAndPayments.Domain.Services;

public interface IPaymentCommandService
{
    Task<(Payment payment, string checkoutUrl)> Handle(CreatePaymentSessionCommand command);
    Task<Payment?> Handle(ProcessPaymentWebhookCommand command);
}