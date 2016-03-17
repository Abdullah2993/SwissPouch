using System;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SwissPouch.Attributes;
using SwissPouch.Extensions;
using SwissPouch.Models;

namespace SwissPouch.Controllers
{
    public class UtilitiesController : ApiController
    {
        [System.Web.Http.HttpPost]
        [Owsv("Convert To Upper Case", "Convert")]
        public string ToUpper([FromBody]DataModel data)
        {
            return data.Data.ToUpper();
        }

        [System.Web.Http.HttpPost]
        [Owsv("Convert To Lower Case", "Convert")]
        public string ToLower([FromBody]DataModel data)
        {
            return data.Data.ToLower();
        }

        [System.Web.Http.HttpPost]
        [Owsv("To Hex String","Convert")]
        public string ToHexString([FromBody] DataModel data)
        {
            return data.Data.ToBytes().ToHex();
        }

        [System.Web.Http.HttpPost]
        [Twsv("Base64 Encode/Decode", "Encode", "Decode")]
        public string Base64([FromUri] int id, [FromBody] DataModel data)
        {
            try
            {
                if (id == 1) return Convert.ToBase64String(data.Data.ToBytes());               
                if (id == 2) return Encoding.UTF8.GetString(Convert.FromBase64String(data.Data));               
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }

        [System.Web.Http.HttpPost]
        [Twsv("Html Encode/Decode", "Encode", "Decode")]
        public string Html([FromUri]int id,[FromBody]DataModel data)
        {
            try
            {
                if (id == 1) return HttpUtility.HtmlEncode(data.Data);
                if (id == 2) return HttpUtility.HtmlDecode(data.Data);
            }
            catch
            {
                //ignore
            }
            return string.Empty;
        }

        [System.Web.Http.HttpPost]
        [Twsv("URL Encode/Decode", "Encode", "Decode")]
        public string Uri([FromUri]int id, [FromBody]DataModel data)
        {
            try
            {
                if (id == 1) return HttpUtility.UrlEncode(data.Data);
                if (id == 2) return HttpUtility.UrlDecode(data.Data);
            }
            catch
            {
                //ignore
            }
            return string.Empty;
        }

    }
}
