using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;
using EMPLOYEES.Repository;
using EMPLOYEES.Repository.Automapper;
using EMPLOYEES.Repository.Common;

namespace EMPLOYEES.Repository
{
    public class Repository : IRepository
    {
        private readonly EMPLOYEES_DbContext _appDbContext;
        private IRepositoryMappingService _mappingService;
        public Repository(EMPLOYEES_DbContext appDbContext, IRepositoryMappingService mapper)
        {
            _appDbContext = appDbContext;
            _mappingService = mapper;
        }
        public IEnumerable<EmployeesLzeljko> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesLzeljko> employeesDb = _appDbContext.EmployeesLzeljko.ToList();
            return employeesDb;
        }
        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {
            IEnumerable<EmployeesLzeljko> employeesDb = _appDbContext.EmployeesLzeljko.ToList();
            IEnumerable<EmployeesDomain> employeesDomains = _mappingService.Map<IEnumerable<EmployeesDomain>>(employeesDb);
            return employeesDomains;
        }
    }
}
