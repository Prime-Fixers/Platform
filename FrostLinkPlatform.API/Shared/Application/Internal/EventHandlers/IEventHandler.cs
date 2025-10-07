using Cortex.Mediator.Notifications;
using FrostLinkPlatform.API.Shared.Domain.Model.Events;

namespace FrostLinkPlatform.API.Shared.Application.Internal.EventHandlers;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
    
}