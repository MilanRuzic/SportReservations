using Application.BusinessLogic.Country.Commands.DeleteCountryCodesCommand;
using Application.Common.Interfaces;
using Application.Shared.Services.Delete;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Surface.Commands.Delete;

public class DeleteSurfaceCodesCommandHandler
    : DeleteCommandHandler<DeleteSurfaceCodesCommand, SurfaceCodes>
{
    public DeleteSurfaceCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}

public class DeleteSurfaceCodesCommand : DeleteCommand { }
