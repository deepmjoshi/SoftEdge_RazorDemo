using RazorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult CurrentDate()
        {
            return PartialView("_PartialCurrentDate", DateTime.Now);
        }

        public ActionResult Contact()
        {
            return View(ModelAddress.GetAllFranchiseAddresses());
        }
        
    }
}