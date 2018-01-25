using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HiddenCreekRanch.Controllers
{
    public class LessonsController : BaseController
    {
        public ActionResult Index()
        {
            return View ("Index");
        }
    }
}
