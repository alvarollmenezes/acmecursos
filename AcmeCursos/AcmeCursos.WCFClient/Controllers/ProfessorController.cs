using AcmeCursos.Models;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace AcmeCursos.WCFClient.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            List<Professor> professores;
            using (var client = new ProfessorService.ProfessorServiceClient())
            {
                professores = client.GetAll().MapTo<List<Professor>>();
            }

            return View(professores);
        }

        // GET: Professor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Professor professor;
            using (var client = new ProfessorService.ProfessorServiceClient())
            {
                professor = client.GetByIdWithCursos(id.Value).MapTo<Professor>();
            }

            if (professor == null)
            {
                return HttpNotFound();
            }
            
            return View(professor);
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Sobrenome,Titulacao")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                using (var client = new ProfessorService.ProfessorServiceClient())
                {
                    client.Create(professor.MapTo<ProfessorService.Professor>());
                }

                return RedirectToAction("Index");
            }

            return View(professor);
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Professor professor;
            using (var client = new ProfessorService.ProfessorServiceClient())
            {
                professor = client.GetById(id.Value).MapTo<Professor>();
            }

            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,Titulacao")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                using (var client = new ProfessorService.ProfessorServiceClient())
                {
                    client.Edit(professor.MapTo<ProfessorService.Professor>());
                }

                return RedirectToAction("Index");
            }
            return View(professor);
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Professor professor;
            using (var client = new ProfessorService.ProfessorServiceClient())
            {
                professor = client.GetById(id.Value).MapTo<Professor>();
            }

            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }

        // POST: Professor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var client = new ProfessorService.ProfessorServiceClient())
            {
                client.Delete(id);
            }

            return RedirectToAction("Index");
        }
    }
}
