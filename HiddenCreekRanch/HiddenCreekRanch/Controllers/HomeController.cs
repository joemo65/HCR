using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HiddenCreekRanch.Models;

namespace HiddenCreekRanch.Controllers
{
    public class HomeController : BaseHiddenCreekRanchController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrance()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
