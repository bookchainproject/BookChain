using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookChain.Models;

namespace BookChain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Who we are:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode = null)
        {
            var error = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                StatusCode = statusCode.HasValue ? statusCode.ToString() : null
            };

            if (statusCode.HasValue)
            {
                if (statusCode == 400)
                {
                    error.AdditionalInfo = "Bad request.";
                }
                else if (statusCode == 404)
                {
                    error.AdditionalInfo = "Page not found or Resource not found.";
                }
                else if (statusCode == 500)
                {
                    error.AdditionalInfo = "Server error, something went wrong.";
                }
                else
                {
                    error.AdditionalInfo = "Unknown error.";
                }
            }

            return View(error);
        }
    }
}
