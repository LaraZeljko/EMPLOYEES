using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Service.Common;
using EMPLOYEES.Model;
using EMPLOYEES.Repository.Common;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace EMPLOYEES.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController:ControllerBase
    {
        protected IService _service { get; private set; }
        public EmployeesController(IService service)
        {
            _service = service;
        }
        /*[HttpGet]
        [Route("add")]
        public IEnumerable<EmployeesLzeljko> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesLzeljko> employeesDb = _service.EmployeesLzeljko.ToList();
            return employeesDb;
        }
        [HttpGet]
        [Route("employees")]*/
        public IEnumerable<EmployeesDomain> GetEmployeesDomains()
            {
                IEnumerable<EmployeesDomain> employeesDomains = _service.GetAllEmployeesDomain();
                return employeesDomains;
            }
    }
    
}
