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
    public class DeliveryPaysheetsController : Controller
    {
        private TruckingDatabaseEntities db = new TruckingDatabaseEntities();

        // GET: DeliveryPaysheets
        public ActionResult Index()
        {
            var deliveryPaysheets = db.DeliveryPaysheets.Include(d => d.Customer).Include(d => d.Driver).Include(d => d.Waiting).Include(d => d.Delivery);
            return View(deliveryPaysheets.ToList());
        }

        // GET: DeliveryPaysheets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryPaysheet deliveryPaysheet = db.DeliveryPaysheets.Find(id);
            if (deliveryPaysheet == null)
            {
                return HttpNotFound();
            }
            return View(deliveryPaysheet);
        }

        // GET: DeliveryPaysheets/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName");
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName");
            ViewBag.WaitingID = new SelectList(db.Waitings, "WaitingId", "WaitingId");
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryId", "DeliveryId");
            return View();
        }

        // POST: DeliveryPaysheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeliveryPaysheetId,DeliveryID,CustomerID,DriverID,OrderDate,ShippedDate,WaitingID")] DeliveryPaysheet deliveryPaysheet)
        {
            if (ModelState.IsValid)
            {
                db.DeliveryPaysheets.Add(deliveryPaysheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName", deliveryPaysheet.CustomerID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName", deliveryPaysheet.DriverID);
            ViewBag.WaitingID = new SelectList(db.Waitings, "WaitingId", "WaitingId", deliveryPaysheet.WaitingID);
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryId", "DeliveryId", deliveryPaysheet.DeliveryID);
            return View(deliveryPaysheet);
        }

        // GET: DeliveryPaysheets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryPaysheet deliveryPaysheet = db.DeliveryPaysheets.Find(id);
            if (deliveryPaysheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName", deliveryPaysheet.CustomerID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName", deliveryPaysheet.DriverID);
            ViewBag.WaitingID = new SelectList(db.Waitings, "WaitingId", "WaitingId", deliveryPaysheet.WaitingID);
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryId", "DeliveryId", deliveryPaysheet.DeliveryID);
            return View(deliveryPaysheet);
        }

        // POST: DeliveryPaysheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeliveryPaysheetId,DeliveryID,CustomerID,DriverID,OrderDate,ShippedDate,WaitingID")] DeliveryPaysheet deliveryPaysheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deliveryPaysheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName", deliveryPaysheet.CustomerID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName", deliveryPaysheet.DriverID);
            ViewBag.WaitingID = new SelectList(db.Waitings, "WaitingId", "WaitingId", deliveryPaysheet.WaitingID);
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryId", "DeliveryId", deliveryPaysheet.DeliveryID);
            return View(deliveryPaysheet);
        }

        // GET: DeliveryPaysheets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryPaysheet deliveryPaysheet = db.DeliveryPaysheets.Find(id);
            if (deliveryPaysheet == null)
            {
                return HttpNotFound();
            }
            return View(deliveryPaysheet);
        }

        // POST: DeliveryPaysheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeliveryPaysheet deliveryPaysheet = db.DeliveryPaysheets.Find(id);
            db.DeliveryPaysheets.Remove(deliveryPaysheet);
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
