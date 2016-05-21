using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AES.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "AES - commited to you";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact AES Grocers";

            return View();
        }
    }
}