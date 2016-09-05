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
    public class jDishWarehousesController : Controller
    {
        private KOMK_v11_Procedure_BasePackEntities2 db = new KOMK_v11_Procedure_BasePackEntities2();

        // GET: jDishWarehouses
        public ActionResult Index()
        {
            var jDishWarehouse = db.jDishWarehouse.Include(j => j.hDish);
            return View(jDishWarehouse.ToList());
        }

        // GET: jDishWarehouses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jDishWarehouse jDishWarehouse = db.jDishWarehouse.Find(id);
            if (jDishWarehouse == null)
            {
                return HttpNotFound();
            }
            return View(jDishWarehouse);
        }

        // GET: jDishWarehouses/Create
        public ActionResult Create()
        {
            ViewBag.DishId = new SelectList(db.hDish, "DishId", "DishName");
            return View();
        }

        // POST: jDishWarehouses/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DishId,DishAmount,DishWarehouseId,DishDate,Exist")] jDishWarehouse jDishWarehouse)
        {
            if (ModelState.IsValid)
            {
                db.jDishWarehouse.Add(jDishWarehouse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DishId = new SelectList(db.hDish, "DishId", "DishName", jDishWarehouse.DishId);
            return View(jDishWarehouse);
        }

        // GET: jDishWarehouses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jDishWarehouse jDishWarehouse = db.jDishWarehouse.Find(id);
            if (jDishWarehouse == null)
            {
                return HttpNotFound();
            }
            ViewBag.DishId = new SelectList(db.hDish, "DishId", "DishName", jDishWarehouse.DishId);
            return View(jDishWarehouse);
        }

        // POST: jDishWarehouses/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DishId,DishAmount,DishWarehouseId,DishDate,Exist")] jDishWarehouse jDishWarehouse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jDishWarehouse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DishId = new SelectList(db.hDish, "DishId", "DishName", jDishWarehouse.DishId);
            return View(jDishWarehouse);
        }

        // GET: jDishWarehouses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jDishWarehouse jDishWarehouse = db.jDishWarehouse.Find(id);
            if (jDishWarehouse == null)
            {
                return HttpNotFound();
            }
            return View(jDishWarehouse);
        }

        // POST: jDishWarehouses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            jDishWarehouse jDishWarehouse = db.jDishWarehouse.Find(id);
            db.jDishWarehouse.Remove(jDishWarehouse);
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
