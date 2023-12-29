using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobTracking.Models.DataContext;
using JobTracking.Models.Staff;


namespace JobTracking.Controllers
{
    public class StaffInfosController : Controller
    {
        private ProjectTrackingDBContext db = new ProjectTrackingDBContext(); //DB Connection

        // GET: StaffInfos
        public ActionResult Index()
        {
            return View(db.StaffInfos.ToList());
        }

        public ActionResult StaffCard()
        {
            return View(db.StaffInfos.ToList());
        }

        // GET: StaffInfos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffInfo staffInfo = db.StaffInfos.Find(id);
            if (staffInfo == null)
            {
                return HttpNotFound();
            }
            return View(staffInfo);
        }

        // GET: StaffInfos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffInfos/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StaffId,Email,Password,Authorization,NameSurname,IdNumber,Department,Task,PositionDetail,PhoneNumber,Address,MaritalStatus,RelativesInformation,RelativesIdNumber,RelativesPhoneNumber,Birthdate,EmploymentDate")] StaffInfo staffInfo)
        {
            if (ModelState.IsValid)
            {
                db.StaffInfos.Add(staffInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(staffInfo);
        }

        // GET: StaffInfos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffInfo staffInfo = db.StaffInfos.Find(id);
            if (staffInfo == null)
            {
                return HttpNotFound();
            }
            return View(staffInfo);
        }

        // POST: StaffInfos/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StaffId,Email,Password,Authorization,NameSurname,IdNumber,Department,Task,PositionDetail,PhoneNumber,Address,MaritalStatus,RelativesInformation,RelativesFullName,RelativesIdNumber,RelativesPhoneNumber,Birthdate,EmploymentDate")] StaffInfo staffInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staffInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staffInfo);
        }

        // GET: StaffInfos/Delete/5
       // public ActionResult Delete(int? id)
       // {
          //  if (id == null)
          //  {
           //     return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
           // }
          //  StaffInfo staffInfo = db.StaffInfos.Find(id);
          //  if (staffInfo == null)
          //  {
          //      return HttpNotFound();
           // }
          //  return View(staffInfo);
      //  }

        // POST: StaffInfos/Delete/5
        //[HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
       // public ActionResult DeleteConfirmed(int id)
       // {
        //    StaffInfo staffInfo = db.StaffInfos.Find(id);
        //    db.StaffInfos.Remove(staffInfo);
       //     db.SaveChanges();
       //     return RedirectToAction("Index");
      //  }

        public ActionResult Delete(int? id)
        {
            if(id == null || id==0)
            {
            return HttpNotFound();
            }

            var t = db.StaffInfos.Find(id);

            db.StaffInfos.Remove(t);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
