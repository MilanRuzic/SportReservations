using Application.BusinessLogic.Country.Commands.DeleteCountryCodesCommand;
using Application.Common.Interfaces;
using Application.Shared.Services.Delete;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.TipAdministrativneJedinice.Commands.DeleteTipAdministrativneJediniceCommand
{
    public class DeleteCountryCodesCommandHandler
        : DeleteCommandHandler<DeleteCountryCodesCommand, CountryCodes>
    {
        public DeleteCountryCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }
    }
}
