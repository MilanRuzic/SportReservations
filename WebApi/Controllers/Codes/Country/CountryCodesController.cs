using Application.BusinessLogic.Country.Commands.CreateCountryCodesCommand;
using Application.BusinessLogic.Country.Commands.DeleteCountryCodesCommand;
using Application.BusinessLogic.Country.Commands.UpdateCountryCodesCommand;
using Application.BusinessLogic.Country.Queries.GetAllQuery;
using Application.BusinessLogic.Country.Queries.GetById;
using Application.Common.Infrastructure.Settings;
using MediatR;
using Microsoft.Extensions.Options;
using WebApi.Controllers.ApiBaseController;

namespace WebApi.Controllers.Codes.Country
{
    public class CountryCodesController(ISender mediator) : ApiBaseController<
        CreateCountryCodesCommand,
        DeleteCountryCodesCommand,
        UpdateCountryCodesCommand,
        GetAllCountryCodesViewModel,
        CountryCodesViewModel,
        GetAllCountryCodesQuery,
        GetCountryCodesByIdQuery
    >(mediator);
}
