using AgileBIForgeInterview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileBIForgeInterview.Controllers
{
    public class DateController : ApiController
    {
        // GET: api/Date
        public DateTime Get()
        {
            return DateTime.UtcNow;
        }

        // GET: api/Date/0
        public DateTime Get(DateType dateType)
        {
           switch(dateType)
            {
                case DateType.Local:
                    return DateTime.Now;
                case DateType.UTC:
                    return DateTime.UtcNow;

            }
            return DateTime.MinValue;
        }

        // POST: api/Date
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Date/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Date/5
        public void Delete(int id)
        {
        }
    }
}
