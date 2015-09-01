using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AcmeCursos.DAL;
using AcmeCursos.Models;

namespace AcmeCursos.Controllers
{
    public class CursoController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: Curso
        public ActionResult Index()
        {
            return View(db.Cursos.ToList());
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Include(c => c.Professores).SingleOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            PopularProfessoresAssociados();

            return View();
        }

        // POST: Curso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao,DataLimiteInscricao")] Curso curso, string[] ProfessoresSelecionados)
        {
            if (ProfessoresSelecionados == null)
            {
                ProfessoresSelecionados = new string[] { };
            }

            if (ModelState.IsValid)
            {
                curso.Professores = db.Professores.Where(p => ProfessoresSelecionados.Contains(p.Id.ToString())).ToList();

                db.Cursos.Add(curso);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curso);
        }


        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Curso curso = db.Cursos.Include(c => c.Professores).SingleOrDefault(c => c.Id == id);

            PopularProfessoresAssociados(curso.Professores);

            if (curso == null)
            {
                return HttpNotFound();
            }

            return View(curso);
        }

        private void PopularProfessoresAssociados(ICollection<Professor> professoresCurso = null)
        {
            professoresCurso = professoresCurso ?? new List<Professor>();

            var professores = db.Professores.ToList();

            var model = new List<SelectListItem>();
            foreach (var p in professores)
            {
                model.Add(new SelectListItem
                {
                    Text = string.Format("{0} {1}", p.Nome, p.Sobrenome),
                    Value = p.Id.ToString(),
                    Selected = professoresCurso.Any(pc => pc.Id == p.Id)
                });
            }

            ViewBag.Professores = model;
        }

        // POST: Curso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao,DataLimiteInscricao")] Curso curso, string[] ProfessoresSelecionados)
        {
            if (ModelState.IsValid)
            {
                var cursoDb = db.Cursos.Include(c => c.Professores).Single(c => c.Id == curso.Id);

                cursoDb.DataLimiteInscricao = curso.DataLimiteInscricao;
                cursoDb.Descricao = curso.Descricao;
                cursoDb.Nome = curso.Nome;
                
                AtualizarProfessoresCurso(cursoDb, ProfessoresSelecionados);

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(curso);
        }

        private void AtualizarProfessoresCurso(Curso curso, string[] ProfessoresSelecionados)
        {
            if (ProfessoresSelecionados == null)
            {
                curso.Professores = new List<Professor>();
                return;
            }

            //Lista dos professores que estão selecionados
            var professoresAdicionar = db.Professores.Where(p => ProfessoresSelecionados.Contains(p.Id.ToString()))
                                                     .ToList();
            //Remove todos os professores que já estão associados ao curso
            professoresAdicionar.RemoveAll(p => curso.Professores.Any(cp => cp.Id == p.Id));
            professoresAdicionar.ForEach(p => curso.Professores.Add(p));

            //Lista de professores que estão associados ao curso mas não estão selecionados
            var professoresRemover = curso.Professores.Where(p => !ProfessoresSelecionados.Contains(p.Id.ToString())).ToList();
            professoresRemover.ForEach(p => curso.Professores.Remove(p));
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Curso curso = db.Cursos.Find(id);

            db.Cursos.Remove(curso);
            
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
