using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Shared.Services.Queries.GetAll;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Queries.GetAllQuery
{
    public class GetAllCountryCodesQueryHandler
        : GetAllQueryHandler<GetAllCountryCodesViewModel, GetAllCountryCodesQuery, CountryCodes>
    {
        public GetAllCountryCodesQueryHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }
    }
}
