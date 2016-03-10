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
        [HttpPost]
        [Owsv("Convert To Upper Case", "Convert","Enter the text here...")]
        public string ToUpper(string data)
        {
            return data?.ToUpper();
        }

        [HttpPost]
        [Owsv("Convert To Lower Case", "Convert")]
        public string ToLower([FromBody]string value)
        {
            return value?.ToLower();
        }
    }
}
