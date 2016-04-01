using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AES.Entities.Shared.Net45.Models;

namespace AES.WebApplication.Controllers
{
    public class ApplicationController : Controller
    {
        private AESEnititiesModel db = new AESEnititiesModel();

        // GET: Application
        public async Task<ActionResult> Index()
        {
            return View(await db.Applications.ToListAsync());
        }

        // GET: Application/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = await db.Applications.FindAsync(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // GET: Application/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ApplicationId,Name,SSN,Address,PhoneNumber,PositionsApplied,SalaryExpectation,FullTime,MondayAvailable,TuesdayAvailable,WednesdayAvailable,ThursdayAvailable,FridayAvailable,SaturdayAvailable,SundayAvailable,MostRecentId,MiddleRecentId,LeastRecentId,RecentEducationId,MiddleEducationId,LeastEducationId,ReferenceId,ApplicationDate")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Applications.Add(application);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(application);
        }

        // GET: Application/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = await db.Applications.FindAsync(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: Application/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ApplicationId,Name,SSN,Address,PhoneNumber,PositionsApplied,SalaryExpectation,FullTime,MondayAvailable,TuesdayAvailable,WednesdayAvailable,ThursdayAvailable,FridayAvailable,SaturdayAvailable,SundayAvailable,MostRecentId,MiddleRecentId,LeastRecentId,RecentEducationId,MiddleEducationId,LeastEducationId,ReferenceId,ApplicationDate")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Entry(application).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(application);
        }

        // GET: Application/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = await db.Applications.FindAsync(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Application application = await db.Applications.FindAsync(id);
            db.Applications.Remove(application);
            await db.SaveChangesAsync();
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
