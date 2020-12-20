using BrothersCompany.Domain.Query;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Query
{
    public class GetQueriesActivity : IActivity<GetQueriesDomainRequest, GetQueriesDomainResponse>
    {
        private readonly IDatabaseAdapter<GetQueriesDomainRequest, GetQueriesDomainResponse> _getQueriesAdapter;
        public GetQueriesActivity(IDatabaseAdapter<GetQueriesDomainRequest, GetQueriesDomainResponse> getQueriesAdapter)
        {
            _getQueriesAdapter = getQueriesAdapter;
        }
        public GetQueriesDomainResponse Execute(GetQueriesDomainRequest input)
        {
            var response = new GetQueriesDomainResponse();

            response = _getQueriesAdapter.Execute(input);
            return response;
        }
    }
}
