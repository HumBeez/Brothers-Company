using BrothersCompany.Domain.Catalog;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Catalog
{
    public class GetCatalogActivity : IActivity<GetCatalogDomainRequest, GetCatalogDomainResponse>
    {
        private readonly IDatabaseAdapter<GetCatalogDomainRequest, GetCatalogDomainResponse> _getCatalogAdapter;
        public GetCatalogActivity(IDatabaseAdapter<GetCatalogDomainRequest, GetCatalogDomainResponse> getCatalogAdapter)
        {
            _getCatalogAdapter = getCatalogAdapter;
        }

        public GetCatalogDomainResponse Execute(GetCatalogDomainRequest input)
        {
            var response = new GetCatalogDomainResponse();
            response = _getCatalogAdapter.Execute(input);
            return response;
        }
    }
}
