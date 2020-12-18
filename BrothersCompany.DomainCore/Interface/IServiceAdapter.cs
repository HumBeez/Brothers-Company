using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DomainCore.Interface
{
    public interface IServiceAdapter<in TInput, out TResult>
    {
        TResult Execute(TInput requestInput);
    }
}
