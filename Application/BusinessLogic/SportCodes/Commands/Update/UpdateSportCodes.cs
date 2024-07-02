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

namespace Application.BusinessLogic.Sport.Commands.Update;

public class UpdateSportCodesCommand : UpdateCommand, IMapFrom<SportCodes>
{
    public string Name { get; set; }
    public bool Active { get; set; }
}

public class UpdateSportCodesHandler : UpdateCommandHandler<UpdateSportCodesCommand, SportCodes>
{
    public UpdateSportCodesHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
