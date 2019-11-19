using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
  public class UnitTest1
  {
    [Fact]
    public async Task Test1()
    {
      HttpClientHandler httpClientHandler = new HttpClientHandler
      {
        Proxy = new WebProxy { BypassProxyOnLocal = true }
      };
      
      HttpClient httpClient = new HttpClient(httpClientHandler) { BaseAddress = new Uri("http://localhost:5000/") };
      var response = await httpClient.GetAsync("api/values");
      var str = await response.Content.ReadAsStringAsync();
      Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
  }
}
