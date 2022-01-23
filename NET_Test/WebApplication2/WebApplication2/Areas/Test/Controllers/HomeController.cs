using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Test/Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AjaxView()
        {
            return PartialView();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}