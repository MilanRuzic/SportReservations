using Application.Common.Interfaces;
using Application.Shared.Services.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Commands.CreateCountryCodesCommand;

public class CreateCountryCodesCommandHandler
    : CreateCommandHandler<CreateCountryCodesCommand, CountryCodes>
{
    public CreateCountryCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
