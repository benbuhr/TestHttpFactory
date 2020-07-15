using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestHttpFactory.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly IHttpClientFactory clientFactory;
        private readonly ITestService testService;

        public TestController(ILogger<TestController> logger, IHttpClientFactory clientFactory, ITestService testService)
        {
            _logger = logger;
            this.clientFactory = clientFactory;
            this.testService = testService;
        }

        [HttpGet("api/test")]
        public async Task<IActionResult> Get()
        {
            return Ok(await testService.GetTest());
        }
    }
}
