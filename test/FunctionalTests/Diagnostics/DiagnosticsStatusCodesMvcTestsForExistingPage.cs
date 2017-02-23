using System.Net;
using System.Net.Http;
using Xunit;
using Xunit.Abstractions;

namespace EntropyTests.Diagnostics
{
    public class DiagnosticsStatusCodesMvcTestsForExistingPage : E2ETestBase
    {
        public DiagnosticsStatusCodesMvcTestsForExistingPage(ITestOutputHelper output)
            : base(output, "Diagnostics.StatusCodes.Mvc", 6100)
        {
        }

        protected override void AssertResponse(HttpResponseMessage response, string responseText)
        {
            var expectedText = "Hello World, try /bob to get a 404";
            Assert.Equal(expectedText, responseText);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
