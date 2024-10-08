﻿using MediatR;

namespace Application.Shared.Services.Update
{
    public class UpdateCommand : IRequest<int>
    {
        public int ID { get; set; }
    }
}
