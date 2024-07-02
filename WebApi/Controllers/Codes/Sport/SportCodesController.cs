using Application.BusinessLogic.Sport.Commands.Create;
using Application.BusinessLogic.Sport.Commands.Delete;
using Application.BusinessLogic.Sport.Commands.Update;
using Application.BusinessLogic.Sport.Queries.GetAllQuery;
using Application.BusinessLogic.Sport.Queries.GetById;
using Application.Common.Infrastructure.Settings;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Controllers.BaseController;

namespace WebApi.Controllers.Codes.Sport;

public class SportCodesController
    : ApiBaseController<
        CreateSportCodesCommand,
        DeleteSportCodesCommand,
        UpdateSportCodesCommand,
        GetAllSportCodesViewModel,
        SportCodesViewModel,
        GetAllSportCodesQuery,
        GetSportCodesByIdQuery
    >
{
    public SportCodesController(ISender mediator)
        : base(mediator) { }
}
