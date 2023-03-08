using AutoMapper;
using DIEmployeeExample.DTO;
using DIEmployeeExample.Model;
using DIEmployeeExample.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIEmployeeExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDIController : ControllerBase
    {
        IMapper _mapper;
        IEmployee employee;
        ILogger _logger;
        public TestDIController(IEmployee e,IMapper mapper,ILogger<TestDIController> logger)
        {
            employee = e;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public string GetEmployee()
        {
            try
            {
                throw new NotImplementedException();
            }

            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }
            return employee.Store();


            _logger.LogInformation("GetEmployee Called");
        }

        [HttpPut]
        public Emp GetEmployee(EmployeeDTO employeeDTO)
        {

            Emp emp = _mapper.Map<Emp>(employeeDTO);
            
            return emp;

            _logger.LogInformation("Mapper Example Called");
        }
    }
}
