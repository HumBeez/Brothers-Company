using BrothersCompany.Domain.Product;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Product
{
    public class SaveProductDetailsAdapter : IDatabaseAdapter<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public SaveProductDetailsAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public SaveProductDetailsDomainResponse Execute(SaveProductDetailsDomainRequest requestInput)
        {
            try
            {
                var response = new SaveProductDetailsDomainResponse();
                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
