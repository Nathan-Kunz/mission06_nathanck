using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission06_nathanck.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_nathanck.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieReviewContext blahcontext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieReviewContext someName)
        {
            _logger = logger;
            blahcontext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       

        [HttpGet]
        public IActionResult form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form(ApplicationResponse ar)
        {
            blahcontext.Add(ar);
            blahcontext.SaveChanges();
            return View("form");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
