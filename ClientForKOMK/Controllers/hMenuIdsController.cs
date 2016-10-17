using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClientForKOMK;

namespace ClientForKOMK.Controllers
{
    public class hMenuIdsController : Controller
    {
        private KOMK_v11_Procedure_BasePackEntities db = new KOMK_v11_Procedure_BasePackEntities();

        // GET: hMenuIds
        public ActionResult Index()
        {
            return View(db.hMenuId.ToList());
        }

        // GET: hMenuIds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hMenuId hMenuId = db.hMenuId.Find(id);
            if (hMenuId == null)
            {
                return HttpNotFound();
            }
            return View(hMenuId);
        }

        // GET: hMenuIds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hMenuIds/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MenuId,MenuDate,Exist")] hMenuId hMenuId)
        {
            if (ModelState.IsValid)
            {
                db.hMenuId.Add(hMenuId);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hMenuId);
        }

        // GET: hMenuIds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hMenuId hMenuId = db.hMenuId.Find(id);
            if (hMenuId == null)
            {
                return HttpNotFound();
            }
            return View(hMenuId);
        }

        // POST: hMenuIds/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MenuId,MenuDate,Exist")] hMenuId hMenuId)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hMenuId).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hMenuId);
        }

        // GET: hMenuIds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hMenuId hMenuId = db.hMenuId.Find(id);
            if (hMenuId == null)
            {
                return HttpNotFound();
            }
            return View(hMenuId);
        }

        // POST: hMenuIds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hMenuId hMenuId = db.hMenuId.Find(id);
            db.hMenuId.Remove(hMenuId);
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
