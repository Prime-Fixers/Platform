using FrostLinkPlatform.API.WorkOrders.Domain.Model.ValueObjects;

namespace FrostLinkPlatform.API.WorkOrders.Domain.Model.Queries;

/// <summary>
/// Represents a query to retrieve Work Orders by their status.
/// </summary>
public record GetWorkOrdersByStatusQuery(EWorkOrderStatus Status);