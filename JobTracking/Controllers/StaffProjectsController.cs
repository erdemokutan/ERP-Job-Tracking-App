using JobTracking.Models.DataContext;
using JobTracking.Models.JobTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTracking.Controllers
{
    public class StaffProjectsController : Controller

    {

        private ProjectTrackingDBContext db = new ProjectTrackingDBContext(); //DB Connection
       
        // GET: StaffProjects
        public ActionResult Index()
        {
            var tasklist = db.StaffProjectss.ToList();
            return View(tasklist);
        }

        public ActionResult Create()
        {
            ViewBag.StaffId = new SelectList(db.StaffInfos, "StaffId", "NameSurname");
            return View();
        }
        [HttpPost]
        public ActionResult Create(StaffProjects projectObj, int[] StaffId)
        {
            foreach (var x in StaffId)
            {
                projectObj.StaffInfos.Add(db.StaffInfos.Find(x));
            }
            projectObj.ProjectAssignmentDate = DateTime.Now;
            db.StaffProjectss.Add(projectObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}