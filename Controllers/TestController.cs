using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ACCOUNTS_WEB.Controllers
{
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        // private readonly ILogger<TestController> _logger;

        // public TestController(ILogger<TestController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}