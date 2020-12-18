using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BrothersCompany.DomainCore.Interface
{
    public interface IConnectionRetreiver
    {
        IDbConnection GetDbConnection();
    }
}
