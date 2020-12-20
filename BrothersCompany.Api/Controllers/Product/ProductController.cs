using BrothersCompany.Contracts.Product;
using BrothersCompany.Domain.Product;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BrothersCompany.Api.Controllers.Product
{
    public class ProductController : ApiController
    {
        private readonly IActivity<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse> _saveProductDetailsActivity;
        private readonly IActivity<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse> _getProductDetailsActivity;

        public ProductController(IActivity<SaveProductDetailsDomainRequest, SaveProductDetailsDomainResponse> saveProductDetailsActivity,
            IActivity<GetProductDetailsDomainRequest, GetProductDetailsDomainResponse> getProductDetailsActivity)
        {
            _saveProductDetailsActivity = saveProductDetailsActivity;
            _getProductDetailsActivity = getProductDetailsActivity;
        }

        [HttpPost]
        [Route("api/SaveProductDetails")]
        public SaveProductDetailsResponse SaveProductDetails(SaveProductDetailsRequest request)
        {
            var response = new SaveProductDetailsResponse();
            var saveProductDetailsDomainRequest = new SaveProductDetailsDomainRequest();
            var saveProductDetailsDomainResponse = new SaveProductDetailsDomainResponse();

            saveProductDetailsDomainResponse = _saveProductDetailsActivity.Execute(saveProductDetailsDomainRequest);
            return response;
        }

        [HttpPost]
        [Route("api/GetProductDetails")]
        public GetProductDetailsResponse GetProductDetails(GetProductDetailsRequest request)
        {
            var response = new GetProductDetailsResponse();
            var getProductDetailsDomainRequest = new GetProductDetailsDomainRequest();
            var getProductDetailsDomainResponse = new GetProductDetailsDomainResponse();

            getProductDetailsDomainResponse = _getProductDetailsActivity.Execute(getProductDetailsDomainRequest);

            return response;
        }
    }
}
