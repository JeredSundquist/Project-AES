using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AES.WebApplication.Client;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;

namespace AES.WebApplication.Controllers
{
    public class PositionRequestController : Controller
    {
        public PositionRequestSvcClient Client { get; }
        
        //constructor
        public PositionRequestController()
        {
            Client = new PositionRequestSvcClient();
        }

        // GET: PositionRequest
        public async Task<ActionResult> Index()
        {
            IEnumerable<PositionRequest> positionRequests = await Client.GetPositionRequests();

            return View(positionRequests);
        }

        // GET: PositionRequest/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PositionRequest positionRequest = await Client.GetPositionRequestById(id);

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
        public async Task<ActionResult> Create([Bind(Include = "RequestId,RequestedBy,RequestedByName,PositionName,StoreId,RequestReason,DateRequested,RequestApproved,ApproveBy,ApprovedByName,DateApproved")] PositionRequest positionRequest)
        {
            if (!ModelState.IsValid) return View(positionRequest);
            {
                await Client.CreatePositionRequest(positionRequest);

                return RedirectToAction("Index");
            }
        }

        // GET: PositionRequest/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PositionRequest positionRequest = await Client.GetPositionRequestById(id);

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
        public async Task<ActionResult> Edit([Bind(Include = "RequestId,RequestedBy,RequestedByName,PositionName,StoreId,RequestReason,DateRequested,RequestApproved,ApproveBy,ApprovedByName,DateApproved")] PositionRequest positionRequest)
        {
            if (!ModelState.IsValid) return View(positionRequest);

            await Client.EditPositionRequest(positionRequest);

            return RedirectToAction("Index");
        }

        // GET: PositionRequest/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PositionRequest positionRequest = await Client.GetPositionRequestById(id);

            if (positionRequest == null)
            {
                return HttpNotFound();
            }
            return View(positionRequest);
        }

        // POST: PositionRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PositionRequest positionRequest = await Client.GetPositionRequestById(id);

            await Client.DeletePositionRequest(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Client.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
