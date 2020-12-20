using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Inquiry
{
    public class GetInquiryDetailsAdapter : IDatabaseAdapter<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public GetInquiryDetailsAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public GetInquiryDetailsDomainResponse Execute(GetInquiryDetailsDomainRequest requestInput)
        {
            try
            {
                var response = new GetInquiryDetailsDomainResponse();


                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
