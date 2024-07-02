using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Shared.Services.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Sport.Commands.Create;

public class CreateSportCodesCommand : CreateCommand, IMapFrom<SportCodes>
{
    public string Name { get; set; }
}

public class CreateSportCodesCommandHandler
    : CreateCommandHandler<CreateSportCodesCommand, SportCodes>
{
    public CreateSportCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}
