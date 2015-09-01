using AcmeCursos.Models;
using AcmeCursos.WCF.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AcmeCursos.WCF
{
    public class CursoService : ICursoService
    {
        public List<Curso> GetAll()
        {
            using (var db = new AppDBContext())
            {
                return db.Cursos.ToList();
            }
        }

        public Curso GetById(int id)
        {
            using (var db = new AppDBContext())
            {
                return db.Cursos.Find(id);
            }
        }

        public Curso GetByIdWithProfessores(int id)
        {
            using (var db = new AppDBContext())
            {
                var curso = db.Cursos
                              .Include(i => i.Professores)
                              .SingleOrDefault(c => c.Id == id);

                foreach (var p in curso.Professores)
                {
                    p.Cursos = null;
                }

                return curso;
            }
        }

        public void Create(Curso curso, int[] professores)
        {
            using (var db = new AppDBContext())
            {
                curso.Professores = db.Professores.Where(p => professores.Contains(p.Id)).ToList();

                db.Cursos.Add(curso);

                db.SaveChanges();
            }
        }

        public void Edit(Curso curso, int[] professores)
        {
            using (var db = new AppDBContext())
            {
                var cursoDb = db.Cursos.Include(c => c.Professores).Single(c => c.Id == curso.Id);

                cursoDb.DataLimiteInscricao = curso.DataLimiteInscricao;
                cursoDb.Descricao = curso.Descricao;
                cursoDb.Nome = curso.Nome;

                AtualizarProfessoresCurso(cursoDb, professores, db);

                db.SaveChanges(); 
            }
        }

        private void AtualizarProfessoresCurso(Curso curso, int[] professores, AppDBContext db)
        {
            if (professores == null)
            {
                curso.Professores = new List<Professor>();
                return;
            }

            //Lista dos professores que estão selecionados
            var professoresAdicionar = db.Professores.Where(p => professores.Contains(p.Id))
                                                     .ToList();
            //Remove todos os professores que já estão associados ao curso
            professoresAdicionar.RemoveAll(p => curso.Professores.Any(cp => cp.Id == p.Id));
            professoresAdicionar.ForEach(p => curso.Professores.Add(p));

            //Lista de professores que estão associados ao curso mas não estão selecionados
            var professoresRemover = curso.Professores.Where(p => !professores.Contains(p.Id)).ToList();
            professoresRemover.ForEach(p => curso.Professores.Remove(p));
        }

        public void Delete(int id)
        {
            using (var db = new AppDBContext())
            {
                Curso curso = db.Cursos.Find(id);

                db.Cursos.Remove(curso);

                db.SaveChanges();
            }
        }
    }
}
