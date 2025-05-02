using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;
using EMPLOYEES.Repository.Common;
using EMPLOYEES.Service.Common;

namespace EMPLOYEES.Service
{
    public class Service:IService
    {
        readonly IRepository _repository;
    public Service(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<EmployeesLzeljko> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesLzeljko> employeesDb = _repository.GetAllEmployeesDb();
            return employeesDb;
        }
        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {
            IEnumerable<EmployeesDomain> employeesDomains = _repository.GetAllEmployeesDomain();
            return employeesDomains;
        }
    }
}
