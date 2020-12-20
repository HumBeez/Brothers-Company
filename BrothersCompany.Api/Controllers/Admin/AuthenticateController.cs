using BrothersCompany.Contracts.Admin;
using BrothersCompany.Domain.Admin;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BrothersCompany.Api.Controllers.Admin
{
    public class AuthenticateController : ApiController
    {
        private readonly IActivity<AuthenticateDomainRequest, AuthenticateDomainResponse> _authenticateActivity;
        public AuthenticateController(IActivity<AuthenticateDomainRequest, AuthenticateDomainResponse> authenticateActivity)
        {
            _authenticateActivity = authenticateActivity;
        }

        [HttpPost]
        [Route("api/Authenticate")]
        public AuthenticateResponse Authenticate(AuthenticateRequest request)
        {
            var response = new AuthenticateResponse();
            var authenticateDomainResponse = new AuthenticateDomainResponse();
            var authenticateDomainRequest = new AuthenticateDomainRequest();

            authenticateDomainResponse = _authenticateActivity.Execute(authenticateDomainRequest);

            return response;

        }
    }
}
