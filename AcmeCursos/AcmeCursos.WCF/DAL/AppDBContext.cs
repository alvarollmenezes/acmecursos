using AcmeCursos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcmeCursos.WCF.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Professor> Professores { get; set; }
    }
}
