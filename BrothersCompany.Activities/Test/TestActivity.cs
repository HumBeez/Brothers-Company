using BrothersCompany.Contracts.Test;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.Activities.Test
{
    public class TestActivity : IActivity<TestRequest, TestResponse>
    {
        public TestResponse Execute(TestRequest input)
        {
            var response = new TestResponse();

            var peace = "Peace Out";
            response.Result = "This is working fine :"+ peace;

            return response;
        }
    }
}
