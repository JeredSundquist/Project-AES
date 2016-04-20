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
    public class UserPermissionController : Controller
    {
        private AESEntitiesModel db = new AESEntitiesModel();

        // GET: UserPermission
        public async Task<ActionResult> Index()
        {
            var userPermissions = db.UserPermissions.Include(u => u.User);
            return View(await userPermissions.ToListAsync());
        }

        // GET: UserPermission/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPermission userPermission = await db.UserPermissions.FindAsync(id);
            if (userPermission == null)
            {
                return HttpNotFound();
            }
            return View(userPermission);
        }

        // GET: UserPermission/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName");
            return View();
        }

        // POST: UserPermission/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserId,editPosition,requestPosition,viewPosition,editStore,viewStore,editTest,viewTest")] UserPermission userPermission)
        {
            if (ModelState.IsValid)
            {
                db.UserPermissions.Add(userPermission);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", userPermission.UserId);
            return View(userPermission);
        }

        // GET: UserPermission/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPermission userPermission = await db.UserPermissions.FindAsync(id);
            if (userPermission == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", userPermission.UserId);
            return View(userPermission);
        }

        // POST: UserPermission/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserId,editPosition,requestPosition,viewPosition,editStore,viewStore,editTest,viewTest")] UserPermission userPermission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userPermission).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", userPermission.UserId);
            return View(userPermission);
        }

        // GET: UserPermission/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPermission userPermission = await db.UserPermissions.FindAsync(id);
            if (userPermission == null)
            {
                return HttpNotFound();
            }
            return View(userPermission);
        }

        // POST: UserPermission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UserPermission userPermission = await db.UserPermissions.FindAsync(id);
            db.UserPermissions.Remove(userPermission);
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
