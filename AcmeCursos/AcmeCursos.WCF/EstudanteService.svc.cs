using AcmeCursos.Models;
using AcmeCursos.WCF.DAL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AcmeCursos.WCF
{
    public class EstudanteService : IEstudanteService
    {
        public List<Estudante> GetAll()
        {
            using (var db = new AppDBContext())
            {
                return db.Estudantes.ToList();
            }
        }

        public Estudante GetById(int id)
        {
            using (var db = new AppDBContext())
            {
                return db.Estudantes.Find(id);
            }
        }

        public Estudante GetByIdWithInscricoes(int id)
        {
            using (var db = new AppDBContext())
            {
                var estudante = db.Estudantes
                                  .Include(e => e.Inscricoes.Select(i => i.Curso))
                                  .SingleOrDefault(e => e.Id == id);

                foreach (var i in estudante.Inscricoes)
                {
                    i.Curso.Inscricoes = null;
                    i.Estudante = null;
                }

                return estudante;
            }
        }

        public void Create(Estudante estudante)
        {
            using (var db = new AppDBContext())
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();
            }
        }

        public void Edit(Estudante estudante)
        {
            using (var db = new AppDBContext())
            {
                db.Entry(estudante).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new AppDBContext())
            {
                var estudante = db.Estudantes.Find(id);

                db.Estudantes.Remove(estudante);

                db.SaveChanges();
            }
        }
    }
}
