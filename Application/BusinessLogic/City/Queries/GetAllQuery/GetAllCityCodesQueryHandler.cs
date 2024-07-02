using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Shared.Services.Queries.GetAll;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Queries.GetAllQuery;

public class GetAllCityCodesQueryHandler
    : GetAllQueryHandler<GetAllCityCodesViewModel, GetAllCityCodesQuery, CityCodes>
{
    public GetAllCityCodesQueryHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
