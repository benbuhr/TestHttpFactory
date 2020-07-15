using System.Net.Http;
using System.Threading.Tasks;

namespace TestHttpFactory
{
    public class TestService : ITestService
    {
        private readonly HttpClient client;

        public TestService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<string> GetTest()
        {
            return await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
        }
    }
}