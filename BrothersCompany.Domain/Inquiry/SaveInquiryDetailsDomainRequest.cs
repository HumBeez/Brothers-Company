using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Domain.Inquiry
{
    public class SaveInquiryDetailsDomainRequest
    {
        public string InquiryName { get; set; }
        public string InquiryEmail { get; set; }
        public long InquiryPhoneNo { get; set; }
        public int ProductId { get; set; }
        public string InquiryMessage { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
    }
}
