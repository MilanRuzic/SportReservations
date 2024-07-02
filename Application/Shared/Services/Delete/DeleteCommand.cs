using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Shared.Services.Delete
{
    public class DeleteCommand : IRequest<int>
    {
        public int ID { get; set; }
    }
}
