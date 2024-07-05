using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderSample.Builders.Advance.Interfaces
{
    public interface IFluentBuilder<T>
    {
        T Build();
    }
}
