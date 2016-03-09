using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SwissPouch.Attributes;

namespace SwissPouch.Controllers
{
    public class ValuesController : ApiController
    {
        [Owsv("Get1","Get It!","/api/values")]
        public string Get()
        {
            return "Test1";
        }

        [Owsv("Get2", "Get It!","")]
        public string Get(int id)
        {
            return "value";
        }

        [Owsv("Post1", "Post It!","/api/values/","POST")]
        public string Post([FromBody]string value)
        {
            return value?.ToUpper();
        }
    }
}
