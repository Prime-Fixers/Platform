using FrostLinkPlatform.API.bc_technicians.Domain.Model.Entities;
using FrostLinkPlatform.API.bc_technicians.Domain.Model.Queries;

namespace FrostLinkPlatform.API.bc_technicians.Domain.Services;

public interface ITechnicianQueryService
{
    Task<Technician?> Handle(GetTechnicianByIdQuery query);
    Task<IEnumerable<Technician>> Handle(GetAllTechniciansQuery query);
    Task<double> Handle(GetTechnicianAverageRatingQuery query);
}