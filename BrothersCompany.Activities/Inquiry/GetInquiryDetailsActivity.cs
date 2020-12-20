using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Inquiry
{
    public class GetInquiryDetailsActivity : IActivity<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse>
    {
        private readonly IDatabaseAdapter<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse> _getInquiryDetailsAdapter;
        public GetInquiryDetailsActivity(IDatabaseAdapter<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse> getInquiryDetailsAdapter)
        {
            _getInquiryDetailsAdapter = getInquiryDetailsAdapter;
        }
        public GetInquiryDetailsDomainResponse Execute(GetInquiryDetailsDomainRequest input)
        {
            var response = new GetInquiryDetailsDomainResponse();

            response = _getInquiryDetailsAdapter.Execute(input);
            return response;
        }
    }
}
