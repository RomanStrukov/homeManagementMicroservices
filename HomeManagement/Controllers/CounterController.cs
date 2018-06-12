using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeManagement.Controllers
{
    public class CounterController : ApiController
    {
        // GET api/counter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/counter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/counter
        public void Post([FromBody]string value)
        {
        }

        // PUT api/counter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/counter/5
        public void Delete(int id)
        {
        }
    }
}
