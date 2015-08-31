using AcmeCursos.Models;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace AcmeCursos.WCFClient.Controllers
{
    public class EstudanteController : Controller
    {
        // GET: Estudante
        public ActionResult Index()
        {
            List<Estudante> estudantes;
            using (var client = new EstudanteService.EstudanteServiceClient())
            {
                estudantes = client.GetAll().MapTo<List<Estudante>>();
            }

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
                using (var client = new EstudanteService.EstudanteServiceClient())
                {
                    client.Create(estudante.MapTo<EstudanteService.Estudante>());
                }
                
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

            Estudante estudante;
            using (var client = new EstudanteService.EstudanteServiceClient())
            {
                estudante = client.GetById(id.Value).MapTo<Estudante>();
            }

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
                using (var client = new EstudanteService.EstudanteServiceClient())
                {
                    client.Edit(estudante.MapTo<EstudanteService.Estudante>());
                }

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

            Estudante estudante;
            using (var client = new EstudanteService.EstudanteServiceClient())
            {
                estudante = client.GetByIdWithInscricoes(id.Value).MapTo<Estudante>();
            }

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

            Estudante estudante;
            using (var client = new EstudanteService.EstudanteServiceClient())
            {
                estudante = client.GetById(id.Value).MapTo<Estudante>();
            }

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
            using (var client = new EstudanteService.EstudanteServiceClient())
            {
                client.Delete(id);
            }
            
            return RedirectToAction("Index");
        }
    }
}
