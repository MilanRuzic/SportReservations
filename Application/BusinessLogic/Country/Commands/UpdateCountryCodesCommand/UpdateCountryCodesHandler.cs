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

namespace Application.BusinessLogic.Country.Commands.UpdateCountryCodesCommand
{
    public class UpdateCountryCodesHandler
        : UpdateCommandHandler<UpdateCountryCodesCommand, CountryCodes>
    {
        public UpdateCountryCodesHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }
    }
}
