using Application.Common.Infrastructure.Settings;
using Application.Common.Interfaces;
using Application.Common.Models.Respones;
using Application.Shared.Services.Create;
using Application.Shared.Services.Delete;
using Application.Shared.Services.Queries.GetAll;
using Application.Shared.Services.Queries.GetByID;
using Application.Shared.Services.Queries.GetForDropdown;
using Application.Shared.Services.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Controllers.BaseController
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
    > : Controller
        where TCreateCommand : CreateCommand
        where TDeleteCommand : DeleteCommand
        where TUpdateCommand : UpdateCommand
        where TGetAllViewModel : class
        where TGetByIdViewModel : class
        where TGetAllQuery : GetAllQuery<TGetAllViewModel>, new()
        where TGetByIdQuery : GetByIdQuery<TGetByIdViewModel>, new()
    {
        private readonly ISender _mediator;

        public ApiBaseController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResponse<TGetAllViewModel>>> Get(
            [FromQuery] TGetAllQuery data
        )
        {
            return Ok(await _mediator.Send(data));
        }

        [HttpPost]
        public async Task<ActionResult<List<int>>> Post(TCreateCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut]
        public async Task<ActionResult<TGetByIdViewModel>> Put(TUpdateCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(TDeleteCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TGetAllViewModel>> GetById(int id)
        {
            return Ok(await _mediator.Send(new TGetByIdQuery { Id = id }));
        }
    }
}
