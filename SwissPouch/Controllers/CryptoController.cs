using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using SwissPouch.Attributes;
using SwissPouch.Extensions;
using SwissPouch.Models;

namespace SwissPouch.Controllers
{
    public class CryptoController : ApiController
    {
        [HttpPost]
        [Owsv("Compute MD5 Hash","Compute")]
        public string Md5([FromBody] DataModel data)
        {
            using (var hasher = MD5.Create())
            {
                return hasher.ComputeHash(data.Data.ToBytes()).ToHex().Replace("-", "");
            }
        }

        [HttpPost]
        [Owsv("Compute Sha1 Hash", "Compute")]
        public string Sha1([FromBody] DataModel data)
        {
            using (var hasher = SHA1.Create())
            {
                return hasher.ComputeHash(data.Data.ToBytes()).ToHex().Replace("-", "");
            }
        }

        [HttpPost]
        [Owsv("Compute Sha256 Hash", "Compute")]
        public string Sha256([FromBody] DataModel data)
        {
            using (var hasher = SHA256.Create())
            {
                return hasher.ComputeHash(data.Data.ToBytes()).ToHex().Replace("-", "");
            }
        }

        [HttpPost]
        [Owsv("Compute Sha384 Hash", "Compute")]
        public string Sha384([FromBody] DataModel data)
        {
            using (var hasher = SHA384.Create())
            {
                return hasher.ComputeHash(data.Data.ToBytes()).ToHex().Replace("-", "");
            }
        }


    }
}
