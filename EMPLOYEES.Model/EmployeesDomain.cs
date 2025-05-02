using EMPLOYEES.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMPLOYEES.Model
{
    public class EmployeesDomain
    {
        public EmployeesDomain()
        {

        }
    public EmployeesDomain(EmployeesLzeljko employee)
    {
            EmpNo = employee.EmpNo;
            BirthDate = employee.BirthDate;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
    }
        public int EmpNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
