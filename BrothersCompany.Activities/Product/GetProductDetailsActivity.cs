using BrothersCompany.Domain.Product;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Product
{
    public class GetProductDetailsActivity : IActivity<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse>
    {
        private readonly IDatabaseAdapter<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse> _getProductDetailsAdapter;
        public GetProductDetailsActivity(IDatabaseAdapter<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse> getProductDetailsAdapter)
        {
            _getProductDetailsAdapter = getProductDetailsAdapter;
        }
        public GetProductDetailsDomainResponse Execute(GetProductDetailsDomainRequest input)
        {
            var response = new GetProductDetailsDomainResponse();
            response = _getProductDetailsAdapter.Execute(input);
            return response;
        }
    }
}
