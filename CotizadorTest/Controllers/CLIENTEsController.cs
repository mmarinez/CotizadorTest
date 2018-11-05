using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CotizadorTest.Models;

namespace CotizadorTest.Controllers
{
    public class CLIENTEsController : Controller
    {
        private CotizadorEntities db = new CotizadorEntities();

        // GET: CLIENTEs
        public ActionResult Index()
        {
            var cLIENTEs = db.CLIENTEs.Include(c => c.PROMOTOR);
            return View(cLIENTEs.ToList());
        }

        // GET: CLIENTEs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTEs.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTE);
        }

        // GET: CLIENTEs/Create
        public ActionResult Create()
        {
            ViewBag.CodigoPromotor = new SelectList(db.PROMOTORs, "CodigoPromotor", "NombrePromotor");
            return View();
        }

        // POST: CLIENTEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NombreCliente,Direccion,Provincia,Telefono,Email,Sector,Municipio,CodigoPromotor,Edad0a5,Edad6a14,Edad15a24,Edad25a34,Edad35a44,Edad45a54,Edad55a64")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTEs.Add(cLIENTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodigoPromotor = new SelectList(db.PROMOTORs, "CodigoPromotor", "NombrePromotor", cLIENTE.CodigoPromotor);
            return View(cLIENTE);
        }

        // GET: CLIENTEs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTEs.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodigoPromotor = new SelectList(db.PROMOTORs, "CodigoPromotor", "NombrePromotor", cLIENTE.CodigoPromotor);
            return View(cLIENTE);
        }

        // POST: CLIENTEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NombreCliente,Direccion,Provincia,Telefono,Email,Sector,Municipio,CodigoPromotor,Edad0a5,Edad6a14,Edad15a24,Edad25a34,Edad35a44,Edad45a54,Edad55a64")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLIENTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodigoPromotor = new SelectList(db.PROMOTORs, "CodigoPromotor", "NombrePromotor", cLIENTE.CodigoPromotor);
            return View(cLIENTE);
        }

        // GET: CLIENTEs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTE cLIENTE = db.CLIENTEs.Find(id);
            if (cLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTE);
        }

        // POST: CLIENTEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CLIENTE cLIENTE = db.CLIENTEs.Find(id);
            db.CLIENTEs.Remove(cLIENTE);
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
