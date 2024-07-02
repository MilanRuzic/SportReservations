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

namespace Application.BusinessLogic.Surface.Queries.GetById;

public class GetSurfaceCodesByIdQuery : GetByIdQuery<SurfaceCodesViewModel> { }

public class GetSurfaceCodesByIdQueryHandler
    : GetByIdQueryHandler<SurfaceCodesViewModel, GetSurfaceCodesByIdQuery, SurfaceCodes>
{
    public GetSurfaceCodesByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}

public class SurfaceCodesViewModel : IMapFrom<CountryCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
}
