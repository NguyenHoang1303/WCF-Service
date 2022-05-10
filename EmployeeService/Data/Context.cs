using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeService.Entity;

namespace EmployeeService.Data
{
    public class Context : DbContext
    {
        public Context() : base("WCFService")
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}