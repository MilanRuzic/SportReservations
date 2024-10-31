using Application.Common.Models.Respones;
using Application.Shared.Services.Create;
using Application.Shared.Services.Delete;
using Application.Shared.Services.Queries.GetAll;
using Application.Shared.Services.Queries.GetByID;
using Application.Shared.Services.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.ApiBaseController
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiBaseController<
        TCreateCommand,
        TDeleteCommand,
        TUpdateCommand,
        TGetAllViewModel,
        TGetByIdViewModel,
        TGetAllQuery,
        TGetByIdQuery
    >(ISender mediator) : Controller
        where TCreateCommand : CreateCommand
        where TDeleteCommand : DeleteCommand
        where TUpdateCommand : UpdateCommand
        where TGetAllViewModel : class
        where TGetByIdViewModel : class
        where TGetAllQuery : GetAllQuery<TGetAllViewModel>, new()
        where TGetByIdQuery : GetByIdQuery<TGetByIdViewModel>, new()
    {
        [HttpGet]
        public async Task<ActionResult<PagedResponse<TGetAllViewModel>>> Get(
            [FromQuery] TGetAllQuery data
        ) =>
            Ok(await mediator.Send(data));

        [HttpPost]
        public async Task<ActionResult<List<int>>> Post(TCreateCommand request) => Ok(await mediator.Send(request));

        [HttpPut]
        public async Task<ActionResult<TGetByIdViewModel>> Put(TUpdateCommand request) => Ok(await mediator.Send(request));

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(TDeleteCommand request) => Ok(await mediator.Send(request));

        [HttpGet("{id}")]
        public async Task<ActionResult<TGetAllViewModel>> GetById(int id) => Ok(await mediator.Send(new TGetByIdQuery { Id = id }));
    }
}
