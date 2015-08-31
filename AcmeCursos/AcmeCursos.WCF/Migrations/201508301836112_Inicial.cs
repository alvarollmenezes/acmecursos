namespace AcmeCursos.WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 15),
                        Descricao = c.String(maxLength: 250),
                        DataLimiteInscricao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inscricao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        EstudanteId = c.Int(nullable: false),
                        DataInscricao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudante", t => t.EstudanteId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.EstudanteId);
            
            CreateTable(
                "dbo.Estudante",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Sobrenome = c.String(maxLength: 50),
                        DataMatricula = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Sobrenome = c.String(maxLength: 50),
                        Titulacao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfessorCursoes",
                c => new
                    {
                        Professor_Id = c.Int(nullable: false),
                        Curso_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professor_Id, t.Curso_Id })
                .ForeignKey("dbo.Professor", t => t.Professor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.Curso_Id, cascadeDelete: true)
                .Index(t => t.Professor_Id)
                .Index(t => t.Curso_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessorCursoes", "Curso_Id", "dbo.Curso");
            DropForeignKey("dbo.ProfessorCursoes", "Professor_Id", "dbo.Professor");
            DropForeignKey("dbo.Inscricao", "EstudanteId", "dbo.Estudante");
            DropForeignKey("dbo.Inscricao", "CursoId", "dbo.Curso");
            DropIndex("dbo.ProfessorCursoes", new[] { "Curso_Id" });
            DropIndex("dbo.ProfessorCursoes", new[] { "Professor_Id" });
            DropIndex("dbo.Inscricao", new[] { "EstudanteId" });
            DropIndex("dbo.Inscricao", new[] { "CursoId" });
            DropTable("dbo.ProfessorCursoes");
            DropTable("dbo.Professor");
            DropTable("dbo.Estudante");
            DropTable("dbo.Inscricao");
            DropTable("dbo.Curso");
        }
    }
}
