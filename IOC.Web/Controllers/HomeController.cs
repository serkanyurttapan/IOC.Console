using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IOC.Web.Models;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDateService _singletonDateService;
        public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService = singletonDateService;
        }
        public IActionResult Index([FromServices]ISingletonDateService singletonDateService2)
        {
            ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = singletonDateService2.GetDateTime.TimeOfDay.ToString();
            return View();
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
