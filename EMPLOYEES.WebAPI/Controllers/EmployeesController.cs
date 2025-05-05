using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using EMPLOYEES.DAL;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Service;
using EMPLOYEES.WebAPI;
using EMPLOYEES.Service.Common;
using EMPLOYEES.Model;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

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
        [HttpGet("employees_db")]
        public IEnumerable<EmployeesLzeljko> GetAllEmployeesDb()
        {
            return _service.GetAllEmployeesDb();
        }

        [HttpGet("employees_domain")]
        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {
            return _service.GetAllEmployeesDomain();
        }
        [HttpGet]
        [Route("ADD")]
        public EmployeesLzeljko ADDemployee(int empNo, DateTime? birthDate, string firstName, string lastName, string gender, DateTime? hireDate)
        {
            EmployeesLzeljko emp = new EmployeesLzeljko
            {
                EmpNo = empNo,
                BirthDate = birthDate,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                HireDate = hireDate
            };
            string connectionString = "Server=193.198.57.183;Database=EMPLOYEES;User Id=student;Password=student;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO EMPLOYEES_LZELJKO (BIRTH_DATE,FIRST_NAME,LAST_NAME,GENDER,HIRE_DATE)" +
                    "VALUES (@birthDate,@FirstName,@LastName,@Gender,@HireDate)";

               /* SqlParameter empNop = new SqlParameter("@EmpNo", SqlDbType.Int, 100);
                empNop.Value = emp.EmpNo;
                command.Parameters.Add(empNop);*/

                SqlParameter birthDatep = new SqlParameter("@birthDate", SqlDbType.DateTime, 100);
                birthDatep.Value = emp.BirthDate;
                command.Parameters.Add(birthDatep);

                SqlParameter firstNamep = new SqlParameter("@FirstName", SqlDbType.Text, 100);
                firstNamep.Value = emp.FirstName;
                command.Parameters.Add(firstNamep);

                SqlParameter lastNamep = new SqlParameter("@LastName", SqlDbType.Text, 100);
                lastNamep.Value = emp.LastName;
                command.Parameters.Add(lastNamep);

                SqlParameter genderp = new SqlParameter("@Gender", SqlDbType.Text, 100);
                genderp.Value = emp.Gender;
                command.Parameters.Add(genderp);

                SqlParameter hireDatep = new SqlParameter("@HireDate", SqlDbType.DateTime, 100);
                hireDatep.Value = emp.HireDate;
                command.Parameters.Add(hireDatep);

                command.Prepare();
                command.ExecuteNonQuery();
            }
                return emp;
        }
        [HttpGet]
        [Route("delete")]
        public void deleteEmployee(int id)
        {
            string connectionString = "Server=193.198.57.183;Database=EMPLOYEES;User Id=student;Password=student;";
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    command.CommandText = "DELETE FROM EMPLOYEES_LZELJKO WHERE EMP_NO="+id;

                    command.Prepare();
                    command.ExecuteNonQuery();
            }
            }
    }
    
}
