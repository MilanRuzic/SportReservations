using Application.Common.Mappings;
using Application.Shared.Services.Create;
using Domain.Entities;

namespace Application.BusinessLogic.City.Commands.Create;

public class CreateCityCodesCommand : CreateCommand, IMapFrom<CityCodes>
{
    public string Name { get; set; }
    public int CountryID { get; set; }
}
