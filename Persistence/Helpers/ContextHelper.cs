using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Persistence.Config;

namespace Persistence.Helpers
{
    public static class ContextHelper
    {
        public static ModelBuilder SetMigrationDefaultValues(this ModelBuilder modelBuilder)
        {
            // Uncomment line bellow for debugging
            //Debugger.Launch();
            var types = modelBuilder.Model.GetEntityTypes().ToArray();
            var typesWithAttribute = types
                .Where(e =>
                    e.ClrType.GetProperties()
                        .Any(prop =>
                            prop.CustomAttributes.Any(ca =>
                                ca.AttributeType == typeof(MigrationDefaultValueAttribute)
                            )
                        )
                )
                .ToList();

            typesWithAttribute.ForEach(type =>
            {
                var typeProps = type
                    .ClrType.GetProperties()
                    .Where(prop =>
                        prop.CustomAttributes.Any(x =>
                            x.AttributeType == typeof(MigrationDefaultValueAttribute)
                        )
                    )
                    .Select(sel => new
                    {
                        PropertyName = sel.Name,
                        sel.GetCustomAttribute<MigrationDefaultValueAttribute>().DefaultValue
                    });

                typeProps.ForEach(tp =>
                {
                    type.GetProperties()
                        .FirstOrDefault(e => e.Name == tp.PropertyName)
                        .SetDefaultValue(tp.DefaultValue);
                });
            });

            return modelBuilder;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
            return source;
        }
    }
}
