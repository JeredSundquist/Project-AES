using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using AES.Entities.Shared.Net45.Models;
using AES.WebApplication.Client;

namespace AES.WebApplication.Controllers
{
    public class PositionClientsController : Controller
    {
        private readonly PositionSvcClient _client = new PositionSvcClient();

        public PositionClientsController()
        {
            _client = new PositionSvcClient();
        }

        // GET: /PositionClients/
        public async Task<ViewResult> Index()
        {
            IEnumerable<Position> positions = null;

            using (var client = new PositionSvcClient())
            {
                positions = await client.GetPositions();
            }

            return View(positions);
        }

        // GET: /PositionClients/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            Position position = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var client = new PositionSvcClient())
            {
                position = await client.GetPositionById(id);
            }

            if (position == null)
            {
                return HttpNotFound();
            }

            return View(position);
        }

        // GET: /PositionClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /PositionClients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Position,Description,FullPartTime,SalaryRange")] Position Position)
        {

            if (ModelState.IsValid)
            {
                Position updatedPosition = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:" + "59095" + "/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // HTTP GET
                    string request = "api/Position";
                    HttpResponseMessage response = await client.PostAsJsonAsync(request, Position);
                    if (response.IsSuccessStatusCode)
                    {
                        updatedPosition = await response.Content.ReadAsAsync<Position>();
                    }
                }

                if (Position != null)
                {
                    TempData["Message"] = "Position " +Position.PositionName + " was successfully created.";
                }

                return RedirectToAction("Index");
            }

            var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => new { x.Key, x.Value.Errors }).ToArray();

            return View(Position);
        }

        // GET: /PositionClients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {

            Position position = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var client = new PositionSvcClient())
            {
                position = await client.GetPositionById(id);
            }

            if (position == null)
            {
                return HttpNotFound();
            }

            return View(position);
        }

        // POST: /PositionClients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Position,Description,FullPartTime,SalaryRange")] Position position)
        {
            if (ModelState.IsValid)
            {
                using (var client = new PositionSvcClient())
                {
                    await client.DeletePosition(position.PositionId);
                }

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://aimadminstrativeservice.cloudapp.net/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // HTTP GET
                    string request = "api/Position";
                    HttpResponseMessage response = await client.PostAsJsonAsync(request, position);
                    if (response.IsSuccessStatusCode)
                    {
                        await response.Content.ReadAsAsync<Position>();
                    }
                }

                TempData["Message"] = "Position " + position.PositionName + " was successfully updated.";

                return RedirectToAction("Index");
            }

            return View(position);
        }

        // GET: /PositionClients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            Position position = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var client = new PositionSvcClient())
            {
                position = await client.GetPositionById(id);
            }

            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: /PositionClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            using (var client = new PositionSvcClient())
            {
                await client.DeletePosition(id);

                Position deletedPosition = await _client.GetPositionById(id);
                if (deletedPosition == null)
                {
                    TempData["Message"] = "Position was successfully deleted.";
                }
                else
                {
                    TempData["Message"] = "Position was not deleted.";
                }
            }

            return RedirectToAction("Index");
        }
    }
}
