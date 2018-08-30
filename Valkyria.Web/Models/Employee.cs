using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valkyria.Web.Models.Constants;

namespace Valkyria.Web.Models
{
    public class Employee
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TypeEmployee TypeEmployee { get; set; }
        public TypeStatus Status { get; set; }
        public List<Employee> ReportsTo { get; set; }
        public List<Employee> ReportsToMe { get; set; }
    }
}
