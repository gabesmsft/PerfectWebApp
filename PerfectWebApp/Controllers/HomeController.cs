using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PerfectWebApp.Models;

namespace PerfectWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int i = 0;
            int j = 1;
            int k = 2;


            if (!string.IsNullOrEmpty(System.Environment.GetEnvironmentVariable("foo")))
            {
                if (System.Environment.GetEnvironmentVariable("foo") == "bar")
                {
                    k = j / i;
                }
            }

            return View(k);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
