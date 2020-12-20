using BrothersCompany.Domain.Query;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DataAccess.Query
{
    public class SaveCustomerQueryAdapter : IDatabaseAdapter<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse>
    {
        private readonly IConnectionRetreiver _connectionRetreiver;
        public SaveCustomerQueryAdapter(IConnectionRetreiver connectionRetreiver)
        {
            _connectionRetreiver = connectionRetreiver;
        }
        public SaveCustomerQueryDomainResponse Execute(SaveCustomerQueryDomainRequest requestInput)
        {
            try
            {
                var response = new SaveCustomerQueryDomainResponse();
                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
