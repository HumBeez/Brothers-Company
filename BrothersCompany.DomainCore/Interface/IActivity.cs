using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DomainCore.Interface
{
    public interface IActivity<in Tinput,out TOutput>
    {
        TOutput Execute(Tinput input);
    }
}
