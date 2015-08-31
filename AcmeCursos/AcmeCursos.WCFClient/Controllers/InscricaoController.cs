using AcmeCursos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AcmeCursos.WCFClient.Controllers
{
    public class InscricaoController : Controller
    {
        [HttpGet]
        public ActionResult CadastrarEstudante()
        {
            List<Estudante> estudantes;
            using (var client = new EstudanteService.EstudanteServiceClient())
            {
                estudantes = client.GetAll().MapTo<List<Estudante>>();
            }

            List<Curso> cursos;
            using (var client = new CursoService.CursoServiceClient())
            {
                cursos = client.GetAll().MapTo<List<Curso>>();
            }

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
                using (var client = new InscricaoService.InscricaoServiceClient())
                {
                    client.CadastrarEstudante(inscricao.MapTo<InscricaoService.Inscricao>());
                }

                ViewBag.Mensagem = "Estudante Cadastrado com sucesso.";
                return View("Sucesso");
            }

            return View(inscricao);
        }
    }
}