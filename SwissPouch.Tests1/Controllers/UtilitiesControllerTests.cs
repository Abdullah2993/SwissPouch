using SwissPouch.Controllers;
using Xunit;

namespace SwissPouch.Tests1.Controllers
{
    public class UtilitiesControllerTests
    {
        private readonly UtilitiesController _utilitiesController;

        public UtilitiesControllerTests()
        {
            _utilitiesController = new UtilitiesController();
        }

        [Fact]
        public void ToUpperTest()
        {
            Assert.Equal("ABC", _utilitiesController.ToUpper("abc".ToDataModel()));
        }

        [Fact]
        public void ToLowerTest()
        {
            Assert.Equal("abc", _utilitiesController.ToLower("ABC".ToDataModel()));
        }

        [Fact()]
        public void ToHexStringTest()
        {
            Assert.Equal("41-42-43", _utilitiesController.ToHexString("ABC".ToDataModel()));
        }

        [Fact()]
        public void Base64EncodingTest()
        {
            Assert.Equal("QUJD", _utilitiesController.Base64(1, "ABC".ToDataModel()));
        }

        [Fact()]
        public void Base64DecodingTest()
        {
            Assert.Equal("ABC", _utilitiesController.Base64(2, "QUJD".ToDataModel()));
        }

        [Fact()]
        public void HtmlEncodeTest()
        {
            Assert.Equal("&lt;abc&gt;Copy &amp; Paste&lt;/abc&gt;",
                _utilitiesController.Html(1, "<abc>Copy & Paste</abc>".ToDataModel()));
        }

        [Fact()]
        public void HtmlDecodeTest()
        {
            Assert.Equal("<abc>Copy & Paste</abc>",
                _utilitiesController.Html(2, "&lt;abc&gt;Copy &amp; Paste&lt;/abc&gt;".ToDataModel()));
        }

        [Fact()]
        public void UriEncodeTest()
        {
            Assert.Equal("http%3a%2f%2fabc.com%2funit%3ftest%3durl+encode%26test%3durl_decode%23encode",
                _utilitiesController.Uri(1, "http://abc.com/unit?test=url encode&test=url_decode#encode".ToDataModel()));
        }

        [Fact()]
        public void UriDecodeTest()
        {
            Assert.Equal("http://abc.com/unit?test=url encode&test=url_decode#encode",
                _utilitiesController.Uri(2,
                    "http%3A%2F%2Fabc.com%2Funit%3Ftest%3Durl%20encode%26test%3Durl_decode%23encode".ToDataModel()));
        }
    }
}