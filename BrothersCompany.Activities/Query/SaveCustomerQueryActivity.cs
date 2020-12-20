using BrothersCompany.Domain.Query;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Query
{
    public class SaveCustomerQueryActivity : IActivity<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse>
    {
        private readonly IDatabaseAdapter<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse> _saveCustomerQueryAdapter;
        public SaveCustomerQueryActivity(IDatabaseAdapter<SaveCustomerQueryDomainRequest, SaveCustomerQueryDomainResponse> saveCustomerQueryAdapter)
        {
            _saveCustomerQueryAdapter = saveCustomerQueryAdapter;
        }
        public SaveCustomerQueryDomainResponse Execute(SaveCustomerQueryDomainRequest input)
        {
            var response = new SaveCustomerQueryDomainResponse();
            response = _saveCustomerQueryAdapter.Execute(input);
            return response;
        }
    }
}
