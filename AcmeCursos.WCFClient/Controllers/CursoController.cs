using AcmeCursos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AcmeCursos.WCFClient.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            List<Curso> cursos;
            using (var client = new CursoService.CursoServiceClient())
            {
                cursos = client.GetAll().MapTo<List<Curso>>();
            }

            return View(cursos);
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Curso curso;
            using (var client = new CursoService.CursoServiceClient())
            {
                curso = client.GetByIdWithProfessores(id.Value).MapTo<Curso>();
            }

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
                ProfessoresSelecionados = new string[]{};
            }

            if (ModelState.IsValid)
            {
                using (var client = new CursoService.CursoServiceClient())
                {
                    client.Create(curso.MapTo<CursoService.Curso>(), ProfessoresSelecionados.Select(p => int.Parse(p)).ToArray());
                }

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

            Curso curso;
            using (var client = new CursoService.CursoServiceClient())
            {
                curso = client.GetByIdWithProfessores(id.Value).MapTo<Curso>();
            }

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

            List<Professor> professores;
            using (var client = new ProfessorService.ProfessorServiceClient())
            {
                professores = client.GetAll().MapTo<List<Professor>>();
            }

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
            if (ProfessoresSelecionados == null)
            {
                ProfessoresSelecionados = new string[] { };
            }

            if (ModelState.IsValid)
            {
                using (var client = new CursoService.CursoServiceClient())
                {
                    client.Edit(curso.MapTo<CursoService.Curso>(), ProfessoresSelecionados.Select(p => int.Parse(p)).ToArray());
                }
                
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Curso curso;
            using (var client = new CursoService.CursoServiceClient())
            {
                curso = client.GetById(id.Value).MapTo<Curso>();
            }
            
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
            using (var client = new CursoService.CursoServiceClient())
            {
                client.Delete(id);
            }
            
            return RedirectToAction("Index");
        }
    }
}
