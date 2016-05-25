using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AES.WebApplication.Controllers;
using AES.Entities.Shared.Net45.Models;
using AES.WebApplication.Client;

namespace AES.WebApplication.Controllers
{
    public class SplashController : Controller
    {
        public ControllerContext Position { get; set; }

        // GET: Splash
        public ActionResult Index()
        {
            return View();
        }
    }
}
