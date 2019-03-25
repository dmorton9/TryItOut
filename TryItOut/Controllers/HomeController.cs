using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryItOut.Controllers.BaseControllers;
using TryItOut.ViewModels;

namespace TryItOut.Controllers
{
    public class HomeController : BaseController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            BasicConfigurator.Configure();

            log.Info("Home controller");

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Welcome() => View("Welcome");

    }
}