using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApp.Models;
using TestApp.Services;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggingService _loggingService;

        public HomeController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public IActionResult Index()
        {
            _loggingService.LogInformation("Home/Index action was called");
            return View();
        }

        public IActionResult Privacy()
        {
            _loggingService.LogInformation("Home/Privacy action was called");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _loggingService.LogError("Home/Error action was called");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
