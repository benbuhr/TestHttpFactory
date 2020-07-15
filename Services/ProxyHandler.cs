using System;
using System.Net;
using System.Net.Http;

namespace TestHttpFactory
{
    public class ProxyHandler : HttpClientHandler
    {
        public ProxyHandler(TestConfiguration configuration)
        {
            Console.WriteLine(configuration.TestUrl);
            this.Proxy = new WebProxy();
        }
    }
}