using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Queries.GetById;

public class CityCodesViewModel : IMapFrom<CountryCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string CountryName { get; set; }
    public bool Active { get; set; }

    public void Mapping(Profile profile)
    {
        profile
            .CreateMap<CityCodes, CityCodesViewModel>()
            .ForMember(dest => dest.CountryName, opts => opts.MapFrom(src => src.Name));
    }
}
