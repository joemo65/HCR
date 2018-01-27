using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HiddenCreekRanch.Controllers
{
    public class ContactUsController : BaseHiddenCreekRanchController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
