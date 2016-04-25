using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AES.Entities.Shared.Net45.Models;

namespace AES.WebApplication.Controllers
{
    public class PositionRequestController : Controller
    {
        private AESEntitiesModel db = new AESEntitiesModel();

        // GET: PositionRequest
        public ActionResult Index()
        {
            return View(db.PositionRequests.ToList());
        }

        // GET: PositionRequest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PositionRequest positionRequest = db.PositionRequests.Find(id);
            if (positionRequest == null)
            {
                return HttpNotFound();
            }
            return View(positionRequest);
        }

        // GET: PositionRequest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PositionRequest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RequestId,RequestedBy,RequestedByName,PositionName,StoreId,RequestReason,DateRequested,RequestApproved,ApproveBy,ApprovedByName,DateApproved")] PositionRequest positionRequest)
        {
            if (ModelState.IsValid)
            {
                db.PositionRequests.Add(positionRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(positionRequest);
        }

        // GET: PositionRequest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PositionRequest positionRequest = db.PositionRequests.Find(id);
            if (positionRequest == null)
            {
                return HttpNotFound();
            }
            return View(positionRequest);
        }

        // POST: PositionRequest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RequestId,RequestedBy,RequestedByName,PositionName,StoreId,RequestReason,DateRequested,RequestApproved,ApproveBy,ApprovedByName,DateApproved")] PositionRequest positionRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(positionRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(positionRequest);
        }

        // GET: PositionRequest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PositionRequest positionRequest = db.PositionRequests.Find(id);
            if (positionRequest == null)
            {
                return HttpNotFound();
            }
            return View(positionRequest);
        }

        // POST: PositionRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PositionRequest positionRequest = db.PositionRequests.Find(id);
            db.PositionRequests.Remove(positionRequest);
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
