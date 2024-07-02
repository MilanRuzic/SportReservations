using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Helpers
{
    public static class ExpressionHelper
    {
        public static Expression<Func<TEntity, bool>> CreateExpression<TEntity>(
            string keyName,
            int Id
        )
        {
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var property = Expression.Equal(
                Expression.Property(parameter, keyName),
                Expression.Constant(Id)
            );
            var expression = Expression.Lambda<Func<TEntity, bool>>(property, parameter);
            return expression;
        }

        public static Expression<Func<TEntity, bool>> ActiveExpression<TEntity>()
        {
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var property = Expression.Equal(
                Expression.Property(parameter, "Active"),
                Expression.Constant(true)
            );
            var expression = Expression.Lambda<Func<TEntity, bool>>(property, parameter);
            return expression;
        }

        public static List<object> GetPrimaryKey<TEntity>(
            TEntity entity,
            IApplicationDbContext context
        )
        {
            var keyProperties = context
                .Model.FindEntityType(entity.GetType())
                ?.GetKeys()
                ?.Where(key => key.IsPrimaryKey())
                ?.FirstOrDefault()
                ?.Properties;
            var result = new List<object>();
            foreach (var property in keyProperties)
            {
                result.Add(property.PropertyInfo.GetValue(entity));
            }
            return result;
        }
    }
}
