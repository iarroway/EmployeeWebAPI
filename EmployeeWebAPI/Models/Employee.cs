using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace EmployeeWebAPI.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public string Department { get; set; }
        public string Mail { get; set; }
        public DateTime? DOJ { get; set; } 
    }
}