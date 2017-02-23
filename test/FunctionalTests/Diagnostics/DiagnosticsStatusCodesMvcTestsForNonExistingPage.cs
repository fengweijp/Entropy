using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace EntropyTests.Diagnostics
{
    public class DiagnosticsStatusCodesMvcTestsForNonExistingPage : E2ETestBase
    {
        public DiagnosticsStatusCodesMvcTestsForNonExistingPage(ITestOutputHelper output)
            : base(output, "Diagnostics.StatusCodes.Mvc", 6200)
        {
        }

        protected override void AssertResponse(HttpResponseMessage response, string responseText)
        {
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        protected override Task<HttpResponseMessage> GetResponse(HttpClient client)
        {
            return client.GetAsync("/bob");
        }
    }
}
