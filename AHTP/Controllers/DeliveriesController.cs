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
    [Authorize]
    public class DeliveriesController : Controller
    {
        private TruckingDatabaseEntities db = new TruckingDatabaseEntities();

        // GET: Deliveries
        public ActionResult Index()
        {
            var deliveries = db.Deliveries.Include(d => d.Customer).Include(d => d.Destination).Include(d => d.Driver).Include(d => d.Order).Include(d => d.Waiting);
            return View(deliveries.ToList());
        }

        // GET: Deliveries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery delivery = db.Deliveries.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            return View(delivery);
        }

        // GET: Deliveries/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName");
            ViewBag.DestinationID = new SelectList(db.Destinations, "DestinationId", "DestinationFr");
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName");
            ViewBag.OrderID = new SelectList(db.Orders, "OrdersId", "OrdersId");
            ViewBag.WaitingId = new SelectList(db.Waitings, "WaitingId", "WaitingId");
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeliveryId,CustomerID,DriverID,OrderID,TruckLicNum,Freight,DestinationID,WaitingId")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                db.Deliveries.Add(delivery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName", delivery.CustomerID);
            ViewBag.DestinationID = new SelectList(db.Destinations, "DestinationId", "DestinationFr", delivery.DestinationID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName", delivery.DriverID);
            ViewBag.OrderID = new SelectList(db.Orders, "OrdersId", "OrdersId", delivery.OrderID);
            ViewBag.WaitingId = new SelectList(db.Waitings, "WaitingId", "WaitingId", delivery.WaitingId);
            return View(delivery);
        }

        // GET: Deliveries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery delivery = db.Deliveries.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName", delivery.CustomerID);
            ViewBag.DestinationID = new SelectList(db.Destinations, "DestinationId", "DestinationFr", delivery.DestinationID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName", delivery.DriverID);
            ViewBag.OrderID = new SelectList(db.Orders, "OrdersId", "OrdersId", delivery.OrderID);
            ViewBag.WaitingId = new SelectList(db.Waitings, "WaitingId", "WaitingId", delivery.WaitingId);
            return View(delivery);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeliveryId,CustomerID,DriverID,OrderID,TruckLicNum,Freight,DestinationID,WaitingId")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(delivery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerId", "FirstName", delivery.CustomerID);
            ViewBag.DestinationID = new SelectList(db.Destinations, "DestinationId", "DestinationFr", delivery.DestinationID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverId", "FirstName", delivery.DriverID);
            ViewBag.OrderID = new SelectList(db.Orders, "OrdersId", "OrdersId", delivery.OrderID);
            ViewBag.WaitingId = new SelectList(db.Waitings, "WaitingId", "WaitingId", delivery.WaitingId);
            return View(delivery);
        }

        // GET: Deliveries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery delivery = db.Deliveries.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            return View(delivery);
        }

        // POST: Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Delivery delivery = db.Deliveries.Find(id);
            db.Deliveries.Remove(delivery);
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
