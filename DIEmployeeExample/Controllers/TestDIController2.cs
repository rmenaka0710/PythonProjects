using DIEmployeeExample.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIEmployeeExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDIController2 : ControllerBase
    {
        IEmployee employee;
        public TestDIController2(IEmployee e)
        {
            employee = e;
        }

        [HttpGet]
        public string StoreEmployee()
        {
            return $"From TestDI 2 {employee.Store()}";
        }
    }
}
