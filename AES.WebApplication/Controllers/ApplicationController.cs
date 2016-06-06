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
using AES.WebApplication.Client;

namespace AES.WebApplication.Controllers
{
    public class ApplicationController : Controller
    {
        public ApplicationSvcClient Client { get; }

        public ApplicationController()
        {
            Client = new ApplicationSvcClient();
        }

        // GET: Application
        public async Task<ActionResult> Index()
        {
            IEnumerable<Application> application = await Client.GetApplications();

            return View(application);
        }

        // GET: Application/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Application application = await Client.GetApplicationById(id);

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
        public async Task<ActionResult> Create([Bind(Include = "ApplicationId,Name,SSN,Address,PhoneNumber,OtherName,Email,PositionsApplied,SalaryExpectation,FullTime,PartTime,Days,Evenings,Weekends,MondayAvailable,TuesdayAvailable,WednesdayAvailable,ThursdayAvailable,FridayAvailable,SaturdayAvailable,SundayAvailable,MostRecentEmployerName,MostRecentEmployerFromDate,MostRecentEmployerToDate,MostRecentEmployerAddress,MostRecentEmployerPhone,MostRecentEmployerSupervisor,MostRecentEmployerPosition,MostRecentEmployerStartSalary,MostRecentEmployerEndSalary,MostRecentEmployerReasonForLeaving,MostRecentEmployerResponsibilities,MiddleRecentEmployerName,MiddleRecentEmployerFromDate,MiddleRecentEmployerToDate,MiddleRecentEmployerAddress,MiddleRecentEmployerPhone,MiddleRecentEmployerSupervisor,MiddleRecentEmployerPosition,MiddleRecentEmployerStartSalary,MiddleRecentEmployerEndSalary,MiddleRecentEmployerReasonForLeaving,MiddleRecentEmployerResponsibilities,LeastRecentEmployerName,LeastRecentEmployerFromDate,LeastRecentEmployerToDate,LeastRecentEmployerAddress,LeastRecentEmployerPhone,LeastRecentEmployerSupervisor,LeastRecentEmployerPosition,LeastRecentEmployerStartSalary,LeastRecentEmployerEndSalary,LeastRecentEmployerReasonForLeaving,LeastRecentEmployerResponsibilities,MostRecentEducationName,MostRecentEducationYearsAttended,MostRecentEducationGraduated,MostRecentEducationDegreeMajor,MiddleRecentEducationName,MiddleRecentEducationYearsAttended,MiddleRecentEducationGraduated,MiddleRecentEducationDegreeMajor,LeastRecentEducationName,LeastRecentEducationYearsAttended,LeastRecentEducationGraduated,LeastRecentEducationDegreeMajor,Reference1Name,Reference1Phone,Reference1Company,Reference1Title,Reference2Name,Reference2Phone,Reference2Company,Reference2Title,Reference3Name,Reference3Phone,Reference3Company,Reference3Title,ApplicationDate")] Application application)
        {
            if (!ModelState.IsValid) return View(application);
            {
                await Client.CreateApplication(application);

                return RedirectToAction("Index");
            }
        }

        // GET: Application/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Application application = await Client.GetApplicationById(id);

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
        public async Task<ActionResult> Edit([Bind(Include = "ApplicationId,Name,SSN,Address,PhoneNumber,OtherName,Email,PositionsApplied,SalaryExpectation,FullTime,PartTime,Days,Evenings,Weekends,MondayAvailable,TuesdayAvailable,WednesdayAvailable,ThursdayAvailable,FridayAvailable,SaturdayAvailable,SundayAvailable,MostRecentEmployerName,MostRecentEmployerFromDate,MostRecentEmployerToDate,MostRecentEmployerAddress,MostRecentEmployerPhone,MostRecentEmployerSupervisor,MostRecentEmployerPosition,MostRecentEmployerStartSalary,MostRecentEmployerEndSalary,MostRecentEmployerReasonForLeaving,MostRecentEmployerResponsibilities,MiddleRecentEmployerName,MiddleRecentEmployerFromDate,MiddleRecentEmployerToDate,MiddleRecentEmployerAddress,MiddleRecentEmployerPhone,MiddleRecentEmployerSupervisor,MiddleRecentEmployerPosition,MiddleRecentEmployerStartSalary,MiddleRecentEmployerEndSalary,MiddleRecentEmployerReasonForLeaving,MiddleRecentEmployerResponsibilities,LeastRecentEmployerName,LeastRecentEmployerFromDate,LeastRecentEmployerToDate,LeastRecentEmployerAddress,LeastRecentEmployerPhone,LeastRecentEmployerSupervisor,LeastRecentEmployerPosition,LeastRecentEmployerStartSalary,LeastRecentEmployerEndSalary,LeastRecentEmployerReasonForLeaving,LeastRecentEmployerResponsibilities,MostRecentEducationName,MostRecentEducationYearsAttended,MostRecentEducationGraduated,MostRecentEducationDegreeMajor,MiddleRecentEducationName,MiddleRecentEducationYearsAttended,MiddleRecentEducationGraduated,MiddleRecentEducationDegreeMajor,LeastRecentEducationName,LeastRecentEducationYearsAttended,LeastRecentEducationGraduated,LeastRecentEducationDegreeMajor,Reference1Name,Reference1Phone,Reference1Company,Reference1Title,Reference2Name,Reference2Phone,Reference2Company,Reference2Title,Reference3Name,Reference3Phone,Reference3Company,Reference3Title,ApplicationDate")] Application application)
        {
            if (!ModelState.IsValid) return View(application);
            {
                await Client.EditApplication(application);

                return RedirectToAction("Index");
            }
        }

        // GET: Application/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Application application = await Client.GetApplicationById(id);

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
            Application application = await Client.GetApplicationById(id);
            await Client.DeleteApplication(id);
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

