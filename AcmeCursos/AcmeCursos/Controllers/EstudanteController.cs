using AcmeCursos.DAL;
using AcmeCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace AcmeCursos.Controllers
{
    public class EstudanteController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: Estudante
        public ActionResult Index()
        {
            var estudantes = db.Estudantes.ToList();

            return View(estudantes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(estudante);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var estudante = db.Estudantes.Find(id);

            if (estudante == null)
            {
                return HttpNotFound();
            }

            return View(estudante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudante).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(estudante);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var estudante = db.Estudantes.Include(i => i.Inscricoes).SingleOrDefault(e => e.Id == id);

            if (estudante == null)
            {
                return HttpNotFound();
            }

            return View(estudante);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var estudante = db.Estudantes.Find(id);

            if (estudante == null)
            {
                return HttpNotFound();
            }

            return View(estudante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var estudante = db.Estudantes.Find(id);

            db.Estudantes.Remove(estudante);

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
