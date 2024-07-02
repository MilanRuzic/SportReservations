using Application.BusinessLogic.Country.Commands.DeleteCountryCodesCommand;
using Application.Common.Interfaces;
using Application.Shared.Services.Delete;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Commands.Delete
{
    public class DeleteCityCodesCommandHandler
        : DeleteCommandHandler<DeleteCityCodesCommand, CityCodes>
    {
        public DeleteCityCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }
    }
}
