using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeManagement.Controllers
{
    public class FeedbackController : ApiController
    {
        // GET api/feedback
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/feedback/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/feedback
        public void Post([FromBody]string value)
        {
        }

        // PUT api/feedback/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/feedback/5
        public void Delete(int id)
        {
        }
    }
}
