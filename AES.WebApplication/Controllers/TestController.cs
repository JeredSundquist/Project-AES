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
    public class TestController : Controller
    {
        private readonly TestSVCClient _client = new TestSVCClient();

        public TestController()
        {
            _client = new TestSVCClient();
        }

        // GET: Test
        public async Task<ActionResult> Index()
        {
            IEnumerable<Test> tests = await _client.GetTests();

            return View(tests);
        }

        // GET: Test/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Test test = await _client.GetTestById(id);

            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TestId,QuestionList,passingScore")] Test test)
        {
            if (ModelState.IsValid)
                return View(test);

            await _client.CreateTest(test);

            return RedirectToAction("Index");
        }

        // GET: Test/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Test test = await _client.GetTestById(id);

            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TestId,QuestionList,passingScore")] Test test)
        {
            if (ModelState.IsValid)
                return View(test);

            await _client.EditTest(test);

            return RedirectToAction("Index");
        }

        // GET: Test/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Test test = await _client.GetTestById(id);

            if (test == null)
            {
                return HttpNotFound();
            }

            return View(test);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Test test = await _client.GetTestById(id);

            await _client.DeleteTest(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _client.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
