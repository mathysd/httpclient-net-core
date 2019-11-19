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
      HttpClient httpClient = new HttpClient
      {
        BaseAddress = new Uri(" http://localhost:5000/")
      };

      var response = await httpClient.GetAsync("api/values");
      Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
  }
}
