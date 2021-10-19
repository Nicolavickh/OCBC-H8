using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region Contructor
        public EmployeeService(ApiDbContext apiDbContext){
            _apiDbContext = apiDbContext;
        }
        #endregion

        public async Task<string> GetEmployeeById(int id){
            var name = await _apiDbContext.employees.Where(c => c.Id == id).Select(d =>d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int id){
            var emp = await _apiDbContext.employees.FirstOrDefaultAsync(c => c.Id == id);
            return emp;
        }
    }
}