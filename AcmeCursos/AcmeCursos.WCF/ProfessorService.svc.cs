using AcmeCursos.Models;
using AcmeCursos.WCF.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AcmeCursos.WCF
{
    public class ProfessorService : IProfessorService
    {
        public List<Professor> GetAll()
        {
            using (var db = new AppDBContext())
            {
                return db.Professores.ToList();
            }
        }

        public Professor GetById(int id)
        {
            using (var db = new AppDBContext())
            {
                return db.Professores.Find(id);
            }
        }

        public Professor GetByIdWithCursos(int id)
        {
            using (var db = new AppDBContext())
            {
                var professor = db.Professores.Include(p => p.Cursos).SingleOrDefault(p => p.Id == id);

                foreach (var c in professor.Cursos)
                {
                    c.Professores = null;
                }

                return professor;
            }
        }

        public void Create(Professor professor)
        {
            using (var db = new AppDBContext())
            {
                db.Professores.Add(professor);
                db.SaveChanges();
            }
        }

        public void Edit(Professor professor)
        {
            using (var db = new AppDBContext())
            {
                db.Entry(professor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new AppDBContext())
            {
                Professor professor = db.Professores.Find(id);
                db.Professores.Remove(professor);
                db.SaveChanges();
            }
        }
    }
}
