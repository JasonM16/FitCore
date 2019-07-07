using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitCore.Web.Maintenance.Models;
using FitCore.Data;

namespace FitCore.Web.Maintenance.Controllers
{
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Exercise");
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
