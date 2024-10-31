using Application.BusinessLogic.Surface.Commands.Create;
using Application.BusinessLogic.Surface.Commands.Delete;
using Application.BusinessLogic.Surface.Commands.Update;
using Application.BusinessLogic.Surface.Queries.GetAllQuery;
using Application.BusinessLogic.Surface.Queries.GetById;
using MediatR;
using WebApi.Controllers.ApiBaseController;

namespace WebApi.Controllers.Codes.Surface;

public class SurfaceCodesController
    : ApiBaseController<
        CreateSurfaceCodesCommand,
        DeleteSurfaceCodesCommand,
        UpdateSurfaceCodesCommand,
        GetAllSurfaceCodesViewModel,
        SurfaceCodesViewModel,
        GetAllSurfaceCodesQuery,
        GetSurfaceCodesByIdQuery
    >
{
    public SurfaceCodesController(ISender mediator)
        : base(mediator) { }
}
