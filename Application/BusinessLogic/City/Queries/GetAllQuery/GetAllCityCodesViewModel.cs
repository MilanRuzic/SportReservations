using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Queries.GetAllQuery;

public class GetAllCityCodesViewModel : IMapFrom<CityCodes>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string CountryName { get; set; }
    public bool Active { get; set; }

    public void Mapping(Profile profile)
    {
        profile
            .CreateMap<CityCodes, GetAllCityCodesViewModel>()
            .ForMember(dest => dest.CountryName, opts => opts.MapFrom(src => src.Country.Name));
    }
}
