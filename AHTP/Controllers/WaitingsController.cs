using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AHTP.Models;

namespace AHTP.Controllers
{
    public class WaitingsController : Controller
    {
        private TruckingDatabaseEntities db = new TruckingDatabaseEntities();

        // GET: Waitings
        public ActionResult Index()
        {
            return View(db.Waitings.ToList());
        }

        // GET: Waitings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Waiting waiting = db.Waitings.Find(id);
            if (waiting == null)
            {
                return HttpNotFound();
            }
            return View(waiting);
        }

        // GET: Waitings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Waitings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WaitingId,ExtraTimePerWait,CostPerWait")] Waiting waiting)
        {
            if (ModelState.IsValid)
            {
                db.Waitings.Add(waiting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(waiting);
        }

        // GET: Waitings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Waiting waiting = db.Waitings.Find(id);
            if (waiting == null)
            {
                return HttpNotFound();
            }
            return View(waiting);
        }

        // POST: Waitings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WaitingId,ExtraTimePerWait,CostPerWait")] Waiting waiting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(waiting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(waiting);
        }

        // GET: Waitings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Waiting waiting = db.Waitings.Find(id);
            if (waiting == null)
            {
                return HttpNotFound();
            }
            return View(waiting);
        }

        // POST: Waitings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Waiting waiting = db.Waitings.Find(id);
            db.Waitings.Remove(waiting);
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
