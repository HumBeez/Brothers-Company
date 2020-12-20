using BrothersCompany.Contracts.Inquiry;
using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Abstract;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Mappers.ContractToDomain.Inquiry
{
    public class SaveInquiryDetailsContractToDomainMapper : BaseMapper<SaveInquiryDetailsRequest, SaveInquiryDetailsDomainRequest>
    {
        public override void Map(SaveInquiryDetailsRequest source, SaveInquiryDetailsDomainRequest target)
        {
            target.InquiryEmail = source.InquiryEmail;
            target.InquiryMessage = source.InquiryMessage;
            target.InquiryName = source.InquiryName;
            target.InquiryPhoneNo = source.InquiryPhoneNo;
            target.ProductId = source.ProductId;
            target.Quantity = source.Quantity;
            target.Status = source.Status;
        }
    }
}
