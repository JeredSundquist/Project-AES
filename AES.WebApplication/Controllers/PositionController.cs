using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AES.Entities.Shared.Net45.Models;
using AES.WebApplication.Client;

namespace AES.WebApplication.Controllers
{
    public class PositionController : Controller
    {
        private readonly PositionSvcClient _client = new PositionSvcClient();

        public PositionController()
        {
            _client = new PositionSvcClient();
        }

        // GET: Position
        public async Task<ActionResult> Index()
        {
            IEnumerable<Position> positions = await _client.GetPositions();
            return View(positions);
        }

        // GET: Position/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Position position = await _client.GetPositionById(id);

            if (position == null)
            {
                return HttpNotFound();
            }

            return View(position);
        }

        // GET: Position/Create
        public async Task<ActionResult> Create()
        {
            IEnumerable<Store> stores = null;
            using (var client = new StoreSvcClient())
            {
                stores = await client.GetStores();
            }

            var storeTitleList = new List<string>();
            var storeTitlesQuery = from s in stores select s.StoreName;

            storeTitleList.AddRange(storeTitlesQuery);
            var storeSelectList = new SelectList(storeTitleList);

            ViewBag.StoreTitles = storeSelectList;
            ViewBag.Stores = stores;

            IEnumerable<Test> tests = null;
            using (var client = new TestSvcClient())
            {
                tests = await client.GetTests();
            }

            var testQuestionList = new List<string>();
            var testTitlesQuery = from t in tests select t.QuestionName;

            testQuestionList.AddRange(testTitlesQuery);
            var testSelectList = new SelectList(testQuestionList);

            ViewBag.TestQuestionList = testSelectList;
            ViewBag.Tests = tests;

            return View();
        }

        // POST: Position/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PositionId,PositionName,PositionDesc,StoreId,TestId")] Position position)
        {
            if (!ModelState.IsValid) return View(position);

            await _client.CreatePosition(position);

            return RedirectToAction("Index");
        }

        // GET: Position/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Position position = await _client.GetPositionById(id);

            IEnumerable<Store> stores = null;
            using (var client = new StoreSvcClient())
            {
                stores = await client.GetStores();
            }

            var storeTitleList = new List<string>();
            var storeTitlesQuery = from s in stores select s.StoreName;

            storeTitleList.AddRange(storeTitlesQuery);
            var storeSelectList = new SelectList(storeTitleList);

            ViewBag.StoreTitles = storeSelectList;
            ViewBag.Stores = stores;

            IEnumerable<Test> tests = null;
            using (var client = new TestSvcClient())
            {
                tests = await client.GetTests();
            }

            var testQuestionList = new List<string>();
            var testTitlesQuery = from t in tests select t.QuestionList;

            testQuestionList.AddRange(testTitlesQuery);
            var testSelectList = new SelectList(testQuestionList);

            ViewBag.TestQuestionList = testSelectList;
            ViewBag.Tests = tests;

            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: Position/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PositionId,PositionName,PositionDesc,StoreId,TestId")] Position position)
        {
            if (!ModelState.IsValid) return View(position);
            await _client.EditPosition(position);

            return RedirectToAction("Index");
        }

        // GET: Position/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Position position = await _client.GetPositionById(id);

            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: Position/Delete/5
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Position position = await _client.GetPositionById(id);
            await _client.DeletePosition(id);
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
