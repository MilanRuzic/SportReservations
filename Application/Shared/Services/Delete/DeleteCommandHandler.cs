using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Shared.Services.Delete
{
    public class DeleteCommandHandler<TCommand, TEntity> : IRequestHandler<TCommand, int>
        where TCommand : DeleteCommand
        where TEntity : BaseEntity
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<int> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var keyName = _context
                .Model.FindEntityType(typeof(TEntity))
                ?.FindPrimaryKey()
                ?.Properties.Select(x => x.Name)
                .Single();

            var entity = await _context
                .Set<TEntity>()
                .Where(x => x.ID == request.ID)
                .FirstOrDefaultAsync();
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChangesAsync(cancellationToken);
            return request.ID;
        }
    }
}
