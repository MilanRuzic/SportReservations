using Application.BusinessLogic.Country.Commands.DeleteCountryCodesCommand;
using Application.Common.Interfaces;
using Application.Shared.Services.Delete;
using AutoMapper;
using Domain.Entities;

namespace Application.BusinessLogic.Sport.Commands.Delete;

public class DeleteSportCodesCommandHandler
    : DeleteCommandHandler<DeleteSportCodesCommand, SportCodes>
{
    public DeleteSportCodesCommandHandler(IApplicationDbContext context, IMapper mapper)
        : base(context, mapper) { }
}

public class DeleteSportCodesCommand : DeleteCommand { }
