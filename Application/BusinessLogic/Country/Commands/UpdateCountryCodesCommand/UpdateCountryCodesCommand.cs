using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Mappings;
using Application.Shared.Services.Update;
using Domain.Entities;

namespace Application.BusinessLogic.Country.Commands.UpdateCountryCodesCommand
{
    public class UpdateCountryCodesCommand : UpdateCommand, IMapFrom<CountryCodes>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
