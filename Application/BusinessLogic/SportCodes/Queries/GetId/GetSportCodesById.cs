using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Shared.Services.Queries.GetByID;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Sport.Queries.GetById;

public class GetSportCodesByIdQuery : GetByIdQuery<SportCodesViewModel> { }

public class GetSportCodesByIdQueryHandler
    : GetByIdQueryHandler<SportCodesViewModel, GetSportCodesByIdQuery, SportCodes>
{
    public GetSportCodesByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}

public class SportCodesViewModel : IMapFrom<CountryCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
}
