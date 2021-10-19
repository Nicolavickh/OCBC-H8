using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Xunit;

namespace UnitTestXUnit
{
    public class EmployeeTest
    {
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

        [Fact]
        public async void GetEmployeeById(){
            mock.Setup(p=>p.GetEmployeeById(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string res = await emp.GetEmployeeById(1);
            Assert.Equal("JK", res);
        }

        [Fact]
        public async void GetEmployeeDetails(){
            var employeeDTO = new Employee(){
                Id = 1,
                Name = "JK",
                Designation = "SDE"
            };
            mock.Setup(p=>p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var res = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(res));
        }
    }
}
