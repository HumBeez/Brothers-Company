using BrothersCompany.Contracts.Inquiry;
using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Mappers.DomainToContract
{
    public class GetInquiryDetailsDomainToContractMapper : BaseMapper<GetInquiryDetailsDomainResponse, GetInquiryDetailsResponse>
    {
        public override void Map(GetInquiryDetailsDomainResponse source, GetInquiryDetailsResponse target)
        {
            foreach (var item in source.InquiryDomainDetails)
            {
                InquiryDetailsList inquiryDetailsList = new InquiryDetailsList
                {
                    InquiryEmail = item.InquiryEmail,
                    InquiryMessage = item.InquiryMessage,
                    InquiryName = item.InquiryName,
                    InquiryPhoneNo = item.InquiryPhoneNo,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Status = item.Status
                };
                target.InquiryDetails.Add(inquiryDetailsList);
            }
            
        }
    }
}
