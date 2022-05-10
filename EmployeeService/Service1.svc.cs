using EmployeeService.Data;
using EmployeeService.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Context context;
        public Service1()
        {
            context = new Context();
        }

        public List<Employee> FindAll()
        {
            return context.Employees.ToList();
        }

        public List<Employee> FindEmployeeByDepartment(string deparment)
        {
            if (string.IsNullOrEmpty(deparment))
            {
                return context.Employees.ToList();
            }
            return context.Employees.Where(e => e.Department.Contains(deparment)).ToList();
        }

        public Employee Save(Employee employee)
        {
            employee.Id = Guid.NewGuid().ToString();
            if (!employee.Validation())
            {
                return null;
            }
            context.Employees.AddOrUpdate(employee);
            context.SaveChanges();
            return employee;
        }
    }
}
