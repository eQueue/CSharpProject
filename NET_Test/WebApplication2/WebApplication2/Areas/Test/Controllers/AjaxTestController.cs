using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.Test.Controllers
{
    public class AjaxTestController : Controller
    {
        // GET: Test/AjaxTest
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}