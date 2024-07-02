using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Shared.Services.Queries.GetByID;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Queries.GetById;

public class GetCityCodesByIdQueryHandler
    : GetByIdQueryHandler<CityCodesViewModel, GetCityCodesByIdQuery, CityCodes>
{
    public GetCityCodesByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
