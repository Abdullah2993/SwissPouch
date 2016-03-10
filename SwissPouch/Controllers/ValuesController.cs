using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SwissPouch.Attributes;

namespace SwissPouch.Controllers
{
    public class UtilitiesController : ApiController
    {
        //[Owsv("Get1","Get It!","/api/values")]
        //public string Get(string data)
        //{
        //    return data?.ToUpper();
        //}

        [HttpGet]
        [Owsv("Get1", "Get It!", "/api/utilities/toupper")]
        public string ToUpper(string data)
        {
            var v = $"dsf";
            return data?.ToUpper();
        }

        [HttpPost]
        [Owsv("Post1", "Post It!","/api/values")]
        public string Post([FromBody]string value)
        {
            return value?.ToUpper();
        }
    }
}
