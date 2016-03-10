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
        [HttpGet]
        [Owsv("Post1", "Post It!")]
        public string ToUpper(string data)
        {
            return data?.ToUpper();
        }

        [HttpPost]
        [Owsv("Post1", "Post It")]
        public string ToLower([FromBody]string value)
        {
            return value?.ToLower();
        }
    }
}
