using BrothersCompany.Contracts.Catalog;
using BrothersCompany.Domain.Catalog;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BrothersCompany.Api.Controllers.Catalog
{
    public class CatalogController : ApiController
    {
        private readonly IActivity<GetCatalogDomainRequest, GetCatalogDomainResponse> _getCatalogActivity;
        public CatalogController(IActivity<GetCatalogDomainRequest, GetCatalogDomainResponse> getCatalogActivity)
        {
            _getCatalogActivity = getCatalogActivity;
        }
        [HttpPost]
        [Route("api/GetCatalog")]
        public GetCatalogResponse GetCatalog(GetCatalogRequest request)
        {
            var response = new GetCatalogResponse();
            var getCatalogDomainRequest = new GetCatalogDomainRequest();
            var getCatalogDomainResponse = new GetCatalogDomainResponse();

            getCatalogDomainResponse = _getCatalogActivity.Execute(getCatalogDomainRequest);

            return response;
        }
    }
}
