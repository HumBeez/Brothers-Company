using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Inquiry
{
    public class SaveInquiryDetailsActivity : IActivity<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse>
    {
        private readonly IDatabaseAdapter<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse> _saveInquiryDetailsAdapter;
        public SaveInquiryDetailsActivity(IDatabaseAdapter<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse> saveInquiryDetailsAdapter)
        {
            _saveInquiryDetailsAdapter = saveInquiryDetailsAdapter;
        }
        public SaveInquiryDetailsDomainResponse Execute(SaveInquiryDetailsDomainRequest input)
        {
            var response = new SaveInquiryDetailsDomainResponse();
            response = _saveInquiryDetailsAdapter.Execute(input);
            return response;
        }
    }
}
