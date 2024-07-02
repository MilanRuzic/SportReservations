using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Config
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MigrationDefaultValueAttribute : Attribute
    {
        public object DefaultValue { get; private set; }

        public MigrationDefaultValueAttribute(object defaultValue)
        {
            DefaultValue = defaultValue;
        }
    }
}
