using AcmeCursos.DAL;
using AcmeCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Controllers
{
    public class InscricaoController : Controller
    {
        private AppDBContext db = new AppDBContext();

        [HttpGet]
        public ActionResult CadastrarEstudante()
        {
            var estudantes = db.Estudantes.ToList();
            var cursos = db.Cursos.ToList();

            var selectEstudantes = estudantes.Select(e => new SelectListItem()
            {
                Text = string.Format("{0} {1}", e.Nome, e.Sobrenome),
                Value = e.Id.ToString()
            }).ToList();

            var selectCursos = cursos.Select(c => new SelectListItem()
            {
                Text = c.Nome,
                Value = c.Id.ToString()
            }).ToList();

            ViewBag.CursoId = selectCursos;
            ViewBag.EstudanteId = selectEstudantes;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarEstudante(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                inscricao.DataInscricao = DateTime.Now;


                db.Inscricoes.Add(inscricao);
                db.SaveChanges();

                ViewBag.Mensagem = "Estudante Cadastrado com sucesso.";
                return View("Sucesso");
            }

            return View(inscricao);
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