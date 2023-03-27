using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] getemployee = { "amit","pandey","jnp" };
        [HttpGet]
        public string[] GetEmployee()
        {
            return getemployee;
        }
        [HttpGet]
        //We can not pass parameter as index because in webconfig there is optional parameter  name as id ...
        //public string GetEmployeeByIndex(int index)
        //{
        //    return getemployee[id];

        //}
        public string GetEmployeeByIndex(int id) 
        {
            return getemployee[id];

        }
    }
}

