using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Application.Common.Helpers;
using Application.Common.Interfaces;
using Application.Common.Models.Respones;
using Application.Shared.Models;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Application.Shared.Services.Update
{
    public class UpdateCommandHandler<TCommand, TEntity> : IRequestHandler<TCommand, int>
        where TCommand : UpdateCommand
        where TEntity : BaseEntity
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UpdateCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<int> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var newEntity = _mapper.Map<TCommand, TEntity>(request);
            var existingEntity = _context.Set<TEntity>().Find(request.ID);

            var properties = _context.Model.FindEntityType(typeof(TEntity))?.GetProperties();

            var propsToIgnore = typeof(BaseEntity).GetProperties().Select(x => x.Name).ToArray();
            foreach (var property in properties)
            {
                if (!propsToIgnore.Contains(property.Name))
                    property.PropertyInfo?.SetValue(
                        existingEntity,
                        property.PropertyInfo.GetValue(newEntity)
                    );
            }
            _context.Set<TEntity>().Update(existingEntity);

            await _context.SaveChangesAsync(cancellationToken);
            return request.ID;
        }
    }
}
