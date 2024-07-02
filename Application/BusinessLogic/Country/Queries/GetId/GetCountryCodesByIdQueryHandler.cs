using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Shared.Services.Queries.GetByID;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Queries.GetById
{
    public class GetCountryCodesByIdQueryHandler
        : GetByIdQueryHandler<CountryCodesViewModel, GetCountryCodesByIdQuery, CountryCodes>
    {
        public GetCountryCodesByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }
    }
}
