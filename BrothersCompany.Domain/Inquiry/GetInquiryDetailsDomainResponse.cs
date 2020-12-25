using BrothersCompany.Contracts.Inquiry;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Domain.Inquiry
{
    public class GetInquiryDetailsDomainResponse
    {
        public GetInquiryDetailsDomainResponse()
        {
            InquiryDomainDetails = new List<InquiryDetailsList>();
        }
        public List<InquiryDetailsList> InquiryDomainDetails { get; set; }
    }
}
