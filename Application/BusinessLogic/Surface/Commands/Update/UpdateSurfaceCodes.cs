using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BusinessLogic.Country.Commands.UpdateCountryCodesCommand;
using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Shared.Services.Update;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Surface.Commands.Update;

public class UpdateSurfaceCodesCommand : UpdateCommand, IMapFrom<SurfaceCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
}

public class UpdateSurfaceCodesHandler
    : UpdateCommandHandler<UpdateSurfaceCodesCommand, SurfaceCodes>
{
    public UpdateSurfaceCodesHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
