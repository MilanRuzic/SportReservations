﻿using Application.BusinessLogic.City.Commands.Create;
using Application.BusinessLogic.City.Commands.Delete;
using Application.BusinessLogic.City.Commands.Update;
using Application.BusinessLogic.City.Queries.GetAllQuery;
using Application.BusinessLogic.City.Queries.GetById;
using Application.Common.Infrastructure.Settings;
using MediatR;
using Microsoft.Extensions.Options;
using WebApi.Controllers.BaseController;

namespace WebApi.Controllers.Codes.City;

public class CityCodesController
    : ApiBaseController<
        CreateCityCodesCommand,
        DeleteCityCodesCommand,
        UpdateCityCodesCommand,
        GetAllCityCodesViewModel,
        CityCodesViewModel,
        GetAllCityCodesQuery,
        GetCityCodesByIdQuery
    >
{
    public CityCodesController(ISender mediator)
        : base(mediator) { }
}