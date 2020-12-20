using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Inquiry
{
    public class SaveInquiryDetailsAdapter : IDatabaseAdapter<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public SaveInquiryDetailsAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public SaveInquiryDetailsDomainResponse Execute(SaveInquiryDetailsDomainRequest requestInput)
        {
            try
            {
                var response = new SaveInquiryDetailsDomainResponse();
                
                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
