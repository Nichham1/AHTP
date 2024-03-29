﻿using System;
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
    public class TruckDetailsController : Controller
    {
        private TruckingDatabaseEntities db = new TruckingDatabaseEntities();

        // GET: TruckDetails
        public ActionResult Index()
        {
            return View(db.TruckDetails.ToList());
        }

        // GET: TruckDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDetail truckDetail = db.TruckDetails.Find(id);
            if (truckDetail == null)
            {
                return HttpNotFound();
            }
            return View(truckDetail);
        }

        // GET: TruckDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TruckDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TruckDetailsId,Type,LicNum")] TruckDetail truckDetail)
        {
            if (ModelState.IsValid)
            {
                db.TruckDetails.Add(truckDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(truckDetail);
        }

        // GET: TruckDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDetail truckDetail = db.TruckDetails.Find(id);
            if (truckDetail == null)
            {
                return HttpNotFound();
            }
            return View(truckDetail);
        }

        // POST: TruckDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TruckDetailsId,Type,LicNum")] TruckDetail truckDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truckDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(truckDetail);
        }

        // GET: TruckDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDetail truckDetail = db.TruckDetails.Find(id);
            if (truckDetail == null)
            {
                return HttpNotFound();
            }
            return View(truckDetail);
        }

        // POST: TruckDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TruckDetail truckDetail = db.TruckDetails.Find(id);
            db.TruckDetails.Remove(truckDetail);
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
