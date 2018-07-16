using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelWebsite.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Index()
        {
            return View("~/Views/index.cshtml");
        }
    }
}