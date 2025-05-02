using System;
using System.Collections.Generic;
using System.Text;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;

namespace EMPLOYEES.Repository.Common
{
    public interface IRepository
    {
        IEnumerable<EmployeesLzeljko> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();

        EmployeesDomain GetEmployeesDomainByEmployeeId(int employeeId);
        //Task<bool> AddEmployeesAsync(EmployeesDomain employee);

    }
}
