using BrothersCompany.Domain.Catalog;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Catalog
{
    public class GetCatalogAdapter : IDatabaseAdapter<GetCatalogDomainRequest, GetCatalogDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public GetCatalogAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public GetCatalogDomainResponse Execute(GetCatalogDomainRequest requestInput)
        {
            try
            {
                var response = new GetCatalogDomainResponse();

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
