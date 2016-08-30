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
    public class hDishesController : Controller
    {
        private KOMK_v11_Procedure_BasePackEntities1 db = new KOMK_v11_Procedure_BasePackEntities1();

        // GET: hDishes
        public ActionResult Index()
        {
            return View(db.hDish.ToList());
        }

        // GET: hDishes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hDish hDish = db.hDish.Find(id);
            if (hDish == null)
            {
                return HttpNotFound();
            }
            return View(hDish);
        }

        // GET: hDishes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hDishes/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DishId,DishName,Exist")] hDish hDish)
        {
            if (ModelState.IsValid)
            {
                db.hDish.Add(hDish);
                db.SaveChanges();
            }

            return View(hDish);
        }

        // GET: hDishes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hDish hDish = db.hDish.Find(id);
            if (hDish == null)
            {
                return HttpNotFound();
            }
            return View(hDish);
        }

        // POST: hDishes/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DishId,DishName,Exist")] hDish hDish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hDish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hDish);
        }

        // GET: hDishes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hDish hDish = db.hDish.Find(id);
            if (hDish == null)
            {
                return HttpNotFound();
            }
            return View(hDish);
        }

        // POST: hDishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hDish hDish = db.hDish.Find(id);
            db.hDish.Remove(hDish);
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
