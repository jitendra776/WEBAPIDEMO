using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAcces;

namespace WEBAPIDEMO.Controllers
{
    public class DemoController : ApiController
    {
        public IEnumerable<Emp> GetAllEmp()
        {
            using (WEBAPIEntities1 obj = new WEBAPIEntities1())
            {
                return obj.Emps.ToList();
            }
        }
        public Emp GetAllEmp(int id)
        {
            using (WEBAPIEntities1 obj = new WEBAPIEntities1())
            {
                return obj.Emps.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
