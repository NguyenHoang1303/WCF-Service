using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeService.Entity
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Department  { get; set; }

        public  bool Validation()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Department))
            {
                return false;
            }
            if (Salary < 0)
            {
                return false;
            }

            return true;

        }
    }
}