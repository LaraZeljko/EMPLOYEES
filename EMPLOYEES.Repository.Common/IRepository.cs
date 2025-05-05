using System;
using System.Collections.Generic;
using System.Text;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;
using System.Threading.Tasks;

namespace EMPLOYEES.Repository.Common
{
    public interface IRepository
    {
        IEnumerable<EmployeesLzeljko> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();

        /*EmployeesDomain GetEmployeesDomainByEmployeeId(int employeeId);
        Task<bool> AddEmployeesAsync(EmployeesDomain employee);
        Task<bool> UpdateEmployeesAsync(EmployeesDomain employee);
        Task<bool> DeleteEmployeesAsync(EmployeesDomain employee);*/

    }
}
