using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PexSampleAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var config = ApplicationConfig.Configuration;
            var config = (Object)null;
            if (null != config)
            {
                ViewBag.testConfigMessage = config["testConfigMessage"] ?? "Couldn't load message from Config Server";
                ViewBag.testConfigMessageClass = config["testConfigMessageClass"] ?? "panel-warning";
            }
            else
            {
                ViewBag.testConfigMessage = "Default message";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}