using BrothersCompany.Domain.Query;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Query
{
    public class GetQueriesAdapter : IDatabaseAdapter<GetQueriesDomainRequest, GetQueriesDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public GetQueriesAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public GetQueriesDomainResponse Execute(GetQueriesDomainRequest requestInput)
        {
            try
            {
                var response = new GetQueriesDomainResponse();

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
