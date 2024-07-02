using Application.Common.Mappings;
using Application.Shared.Services.Create;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Commands.CreateCountryCodesCommand;

public class CreateCountryCodesCommand : CreateCommand, IMapFrom<CountryCodes>
{
    public string Name { get; set; }
}
