using AcmeCursos.Models;
using AcmeCursos.WCF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AcmeCursos.WCF
{
    public class InscricaoService : IInscricaoService
    {
        public void CadastrarEstudante(Inscricao inscricao)
        {
            using (var db = new AppDBContext())
            {
                inscricao.DataInscricao = DateTime.Now;

                db.Inscricoes.Add(inscricao);
                db.SaveChanges();
            }
        }

        public List<Inscricao> GetByEstudanteId(int estudanteId)
        {
            using (var db = new AppDBContext())
            {
                return db.Inscricoes.Include(i => i.Curso).Where(i => i.EstudanteId == estudanteId).ToList();
            }
        }
    }
}
