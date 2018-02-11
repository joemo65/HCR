using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HiddenCreekRanch.Controllers
{
    public class StartController : BaseHiddenCreekRanchController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrance()
        {
            return View();
        }
    }
}
