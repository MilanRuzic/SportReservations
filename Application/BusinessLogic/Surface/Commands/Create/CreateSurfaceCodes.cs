using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Shared.Services.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Surface.Commands.Create;

public class CreateSurfaceCodesCommand : CreateCommand, IMapFrom<SurfaceCodes>
{
    public string Name { get; set; }
}

public class CreateSurfaceCodesCommandHandler
    : CreateCommandHandler<CreateSurfaceCodesCommand, SurfaceCodes>
{
    public CreateSurfaceCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
