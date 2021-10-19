using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;

namespace UnitTest_Mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Property
        private readonly IEmployeeService _employeeService;
        #endregion

        #region Contructor
        public EmployeeController(IEmployeeService employeeService){
            _employeeService = employeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int id){
            var res = await _employeeService.GetEmployeeById(id);
            return res;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int id){
            var res = await _employeeService.GetEmployeeDetails(id);
            return res;
        }
    }
}