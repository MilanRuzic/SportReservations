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

namespace Application.BusinessLogic.Surface.Queries.GetAllQuery;

public class GetAllSurfaceCodesQueryHandler
    : GetAllQueryHandler<GetAllSurfaceCodesViewModel, GetAllSurfaceCodesQuery, SurfaceCodes>
{
    public GetAllSurfaceCodesQueryHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}

public class GetAllSurfaceCodesQuery : GetAllQuery<GetAllSurfaceCodesViewModel> { }

public class GetAllSurfaceCodesViewModel : IMapFrom<SurfaceCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
}
