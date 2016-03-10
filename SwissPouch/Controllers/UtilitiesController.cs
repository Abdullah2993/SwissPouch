using System;
using System.Text;
using System.Web;
using System.Web.Http;
using SwissPouch.Attributes;
using SwissPouch.Extensions;

namespace SwissPouch.Controllers
{
    public class UtilitiesController : ApiController
    {
        [HttpPost]
        [Owsv("Convert To Upper Case", "Convert")]
        public string ToUpper([FromBody]string data)
        {
            return data?.ToUpper();
        }

        [HttpPost]
        [Owsv("Convert To Lower Case", "Convert")]
        public string ToLower([FromBody]string data)
        {
            return data?.ToLower();
        }

        [HttpPost]
        [Owsv("To Hex String","Convert")]
        public string ToHexString([FromBody] string data)
        {
            return data?.ToBytes().ToHex();
        }

        [HttpPost]
        [Twsv("Base64 Encode/Decode", "Encode", "Decode")]
        public string Base64([FromUri] int id, [FromBody] string data)
        {
            if (data == null) return string.Empty;
            try
            {
                if (id == 1) return Convert.ToBase64String(data.ToBytes());               
                if (id == 2) return Encoding.UTF8.GetString(Convert.FromBase64String(data));               
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }

        [HttpPost]
        [Twsv("Html Encode/Decode", "Encode", "Decode")]
        public string Html([FromUri]int id,[FromBody]string data)
        {
            if (data == null) return string.Empty;
            try
            {
                if (id == 1) return HttpUtility.HtmlEncode(data);
                if (id == 2) return HttpUtility.HtmlDecode(data);
            }
            catch
            {
                //ignore
            }
            return string.Empty;
        }

        [HttpPost]
        [Twsv("URL Encode/Decode", "Encode", "Decode")]
        public string Uri([FromUri]int id, [FromBody]string data)
        {
            if (data == null) return string.Empty;
            try
            {
                if (id == 1) return HttpUtility.UrlEncode(data);
                if (id == 2) return HttpUtility.UrlDecode(data);
            }
            catch
            {
                //ignore
            }
            return string.Empty;
        }

    }
}
