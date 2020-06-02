using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using EmployeeWebAPI.Models;


namespace EmployeeWebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = " select DepartmentID, DepartmentName from dbo.Departments";

            using (var con)
        }
    }
}
