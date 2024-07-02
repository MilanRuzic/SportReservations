using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Queries.GetAllQuery
{
    public class GetAllCountryCodesViewModel : IMapFrom<CountryCodes>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
