using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;

namespace EMPLOYEES.Repository.Automapper
{
    public class RepositoryMappingService:IRepositoryMappingService
    {
        public Mapper mapper;
        public RepositoryMappingService()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<EmployeesLzeljko, EmployeesDomain>();
                    cfg.CreateMap<EmployeesDomain, EmployeesLzeljko>();
                });
            mapper = new Mapper(config);
        }
        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}
