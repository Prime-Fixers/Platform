using FrostLinkPlatform.API.bc_technicians.Domain.Model.Entities;
using FrostLinkPlatform.API.bc_technicians.Domain.Repositories;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using FrostLinkPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace FrostLinkPlatform.API.bc_technicians.Infrastructure.Persistence.EFC.Repositories;

public class TechnicianRepository(AppDbContext context) : 
    BaseRepository<Technician>(context), 
    ITechnicianRepository;

