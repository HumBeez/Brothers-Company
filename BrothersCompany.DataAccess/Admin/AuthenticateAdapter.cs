using BrothersCompany.Domain.Admin;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Admin
{
    public class AuthenticateAdapter : IDatabaseAdapter<AuthenticateDomainRequest, AuthenticateDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public AuthenticateAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public AuthenticateDomainResponse Execute(AuthenticateDomainRequest requestInput)
        {
            try
            {
                var response = new AuthenticateDomainResponse();

                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
