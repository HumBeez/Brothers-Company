using BrothersCompany.Domain.Product;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Product
{
    public class GetProductDetailsAdapter : IDatabaseAdapter<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public GetProductDetailsAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public GetProductDetailsDomainResponse Execute(GetProductDetailsDomainRequest requestInput)
        {
            try
            {
                var response = new GetProductDetailsDomainResponse();

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
