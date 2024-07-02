using Application.Common.Mappings;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Queries.GetById
{
    public class CountryCodesViewModel : IMapFrom<CountryCodes>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
