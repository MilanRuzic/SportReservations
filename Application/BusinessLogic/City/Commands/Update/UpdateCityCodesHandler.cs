using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BusinessLogic.Country.Commands.UpdateCountryCodesCommand;
using Application.Common.Interfaces;
using Application.Shared.Services.Update;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Commands.Update;

public class UpdateCityCodesHandler : UpdateCommandHandler<UpdateCityCodesCommand, CityCodes>
{
    public UpdateCityCodesHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
