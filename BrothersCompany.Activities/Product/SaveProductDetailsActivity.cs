using BrothersCompany.Domain.Product;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Product
{
    public class SaveProductDetailsActivity : IActivity<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse>
    {
        private readonly IDatabaseAdapter<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse> _saveProductDetailsAdapter;
        public SaveProductDetailsActivity(IDatabaseAdapter<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse> saveProductDetailsAdapter)
        {
            _saveProductDetailsAdapter = saveProductDetailsAdapter;
        }
        public SaveProductDetailsDomainResponse Execute(SaveProductDetailsDomainRequest input)
        {
            var response = new SaveProductDetailsDomainResponse();
            response = _saveProductDetailsAdapter.Execute(input);
            return response;
        }
    }
}
