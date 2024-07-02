using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Shared.Services.Queries.GetAll;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Sport.Queries.GetAllQuery;

public class GetAllSportCodesQueryHandler
    : GetAllQueryHandler<GetAllSportCodesViewModel, GetAllSportCodesQuery, SportCodes>
{
    public GetAllSportCodesQueryHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}

public class GetAllSportCodesQuery : GetAllQuery<GetAllSportCodesViewModel> { }

public class GetAllSportCodesViewModel : IMapFrom<SportCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
}
