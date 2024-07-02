using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Models;
using Application.Common.Models.Respones;
using MediatR;

namespace Application.Shared.Services.Queries.GetAll
{
    public class GetAllQuery<TViewModel> : PaginationQuery, IRequest<PagedResponse<TViewModel>>
        where TViewModel : class { }
}
