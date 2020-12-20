﻿using BrothersCompany.Contracts.Inquiry;
using BrothersCompany.Domain.Inquiry;
using BrothersCompany.DomainCore.Abstract;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BrothersCompany.Api.Controllers.Inquiry
{
    public class InquiryController : ApiController
    {
        private readonly IActivity<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse> _saveInquiryDetailsActivity;
        private readonly IActivity<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse> _getInquiryDetailsActivity;

        private readonly BaseMapper<SaveInquiryDetailsRequest, SaveInquiryDetailsDomainRequest> _saveInquiryDetailsContractToDomainMapper;
        public InquiryController(IActivity<SaveInquiryDetailsDomainRequest, SaveInquiryDetailsDomainResponse> saveInquiryDetailsActivity,
            IActivity<GetInquiryDetailsDomainRequest, GetInquiryDetailsDomainResponse> getInquiryDetailsActivity,
            BaseMapper<SaveInquiryDetailsRequest, SaveInquiryDetailsDomainRequest> saveInquiryDetailsContractToDomainMapper)
        {
            _saveInquiryDetailsActivity = saveInquiryDetailsActivity;
            _getInquiryDetailsActivity = getInquiryDetailsActivity;
            _saveInquiryDetailsContractToDomainMapper = saveInquiryDetailsContractToDomainMapper;

        }
        [HttpPost]
        [Route("api/SaveInquiryDetails")]
        public SaveInquiryDetailsResponse SaveInquiryDetails(SaveInquiryDetailsRequest request)
        {
            var response = new SaveInquiryDetailsResponse();
            var saveInquiryDetailsDomainRequest = new SaveInquiryDetailsDomainRequest();
            var saveInquiryDetailsDomainResponse = new SaveInquiryDetailsDomainResponse();

            _saveInquiryDetailsContractToDomainMapper.Map(request,saveInquiryDetailsDomainRequest);
            saveInquiryDetailsDomainResponse = _saveInquiryDetailsActivity.Execute(saveInquiryDetailsDomainRequest);
            saveInquiryDetailsDomainResponse.IsInquirySaved = response.IsInquirySaved;
            return response;
        }

        [HttpPost]
        [Route("api/GetInquiryDetails")]
        public GetInquiryDetailsResponse GetInquiryDetails(GetInquiryDetailsRequest request)
        {
            var response = new GetInquiryDetailsResponse();
            var getInquiryDetailsDomainRequest = new GetInquiryDetailsDomainRequest();
            var getInquiryDetailsDomainResponse = new GetInquiryDetailsDomainResponse();


            getInquiryDetailsDomainResponse = _getInquiryDetailsActivity.Execute(getInquiryDetailsDomainRequest);

            return response;
        }

    }
}
