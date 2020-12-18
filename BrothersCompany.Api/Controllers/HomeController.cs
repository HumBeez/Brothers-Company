using BrothersCompany.Contracts.Test;
using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BrothersCompany.Api.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IActivity<TestRequest, TestResponse> _testActivity;
        public HomeController(IActivity<TestRequest, TestResponse> testActivity)
        {
            _testActivity = testActivity;
        }
        [HttpPost]
        [Route("api/GetTestValues")]
        public TestResponse GetTestValues(TestRequest testRequest)
        {
            var response = new TestResponse();
            response =_testActivity.Execute(testRequest);
            return response;
        }
    }
}
