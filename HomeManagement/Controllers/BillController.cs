using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeManagement.Controllers
{
    public class BillController : ApiController
    {
        // GET api/bill
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/bill/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/bill
        public void Post([FromBody]string value)
        {
        }

        // PUT api/bill/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/bill/5
        public void Delete(int id)
        {
        }
    }
}
