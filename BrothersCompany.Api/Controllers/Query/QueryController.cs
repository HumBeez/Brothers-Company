using BrothersCompany.Contracts.Query;
using BrothersCompany.Domain.Query;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BrothersCompany.Api.Controllers.Query
{
    public class QueryController : ApiController
    {
        private readonly IActivity<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse> _saveCustomerQueryActivity;
        private readonly IActivity<GetQueriesDomainRequest, GetQueriesDomainResponse> _getQueriesActivity;
        public QueryController(IActivity<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse> saveCustomerQueryActivity,
            IActivity<GetQueriesDomainRequest, GetQueriesDomainResponse> getQueriesActivity)
        {
            _saveCustomerQueryActivity = saveCustomerQueryActivity;
            _getQueriesActivity = getQueriesActivity;
        }
        [HttpPost]
        [Route("api/SaveCustomerQuery")]
        public SaveCustomerQueryResponse SaveCustomerQuery (SaveCustomerQueryRequest request)
        {
            var response = new SaveCustomerQueryResponse();
            var saveCustomerQueryDomainRequest = new SaveCustomerQueryDomainRequest();
            var saveCustomerQueryDomainResponse = new SaveCustomerQueryDomainResponse();

            saveCustomerQueryDomainResponse = _saveCustomerQueryActivity.Execute(saveCustomerQueryDomainRequest);

            return response;
        }
        [HttpPost]
        [Route("api/GetQueries")]
        public GetQueriesResponse GetQueries(GetQueriesRequest request)
        {
            var response = new GetQueriesResponse();
            var getQueriesDomainRequest = new GetQueriesDomainRequest();
            var getQueriesDomainResponse = new GetQueriesDomainResponse();

            getQueriesDomainResponse = _getQueriesActivity.Execute(getQueriesDomainRequest);

            return response;
        }
    }
}
