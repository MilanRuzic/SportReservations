using Application.Common.Interfaces;
using Application.Shared.Services.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.City.Commands.Create;

public class CreateCityCodesCommandHandler : CreateCommandHandler<CreateCityCodesCommand, CityCodes>
{
    public CreateCityCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
