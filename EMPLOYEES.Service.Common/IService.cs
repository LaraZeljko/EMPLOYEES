using System;
using System.Collections.Generic;
using System.Text;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;

namespace EMPLOYEES.Service.Common
{
    public interface IService
    {
        IEnumerable<EmployeesLzeljko> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();
    }
}
