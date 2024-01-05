using JobTracking.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTracking.Controllers
{
    public class OverviewController : Controller
    {
        private readonly ProjectTrackingDBContext db = new ProjectTrackingDBContext(); //DB Connection
        // GET: Overview
        public ActionResult Index()
        {
            return View();
        }
    }
}