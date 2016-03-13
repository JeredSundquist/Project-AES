﻿using System;
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
    public class StoreController : Controller
    {
        private readonly StoreSvcClient _client = new StoreSvcClient();

        public StoreController()
        {
            _client = new StoreSvcClient();
        }

        // GET: Store
        public async Task<ActionResult> Index()
        {
            IEnumerable<Store> stores = await _client.GetStores();

            return View(stores);
        }

        // GET: /Store/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Store store = await _client.GetStoreById(id);

            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Store/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StoreId,StoreLocation,StoreName")] Store store)

        {
            if (!ModelState.IsValid) return View(store);
            await _client.CreateStore(store);

            return RedirectToAction("Index");
        }

        // GET: Store/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Store store = await _client.GetStoreById(id);

            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // POST: Store/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StoreId,StoreLocation,StoreName")] Store store)
        {
            if (!ModelState.IsValid) return View(store);
            await _client.EditStore(store);

            return RedirectToAction("Index");
        }

        // GET: Store/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Store store = await _client.GetStoreById(id);

            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // POST: Store/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Store store = await _client.GetStoreById(id);
            await _client.DeleteStore(id);
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
