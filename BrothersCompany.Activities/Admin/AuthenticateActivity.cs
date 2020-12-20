using BrothersCompany.Domain.Admin;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Admin
{
    public class AuthenticateActivity : IActivity<AuthenticateDomainRequest, AuthenticateDomainResponse>
    {
        private readonly IDatabaseAdapter<AuthenticateDomainRequest, AuthenticateDomainResponse> _authenticateAdapter;
        public AuthenticateActivity(IDatabaseAdapter<AuthenticateDomainRequest, AuthenticateDomainResponse> authenticateAdapter)
        {
            _authenticateAdapter = authenticateAdapter;
        }
        public AuthenticateDomainResponse Execute(AuthenticateDomainRequest input)
        {
            var response = new AuthenticateDomainResponse();
            response = _authenticateAdapter.Execute(input);
            return response;
        }
    }
}
