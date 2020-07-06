using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace areaproj.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            bool IsAuth = false;
            if (IsAuth)
                return View();
            else
                return View("~/Areas/Admin/Views/Home/test.cshtml");
            
        }
        public ActionResult test()
        {
           return View();
        }
    }
}