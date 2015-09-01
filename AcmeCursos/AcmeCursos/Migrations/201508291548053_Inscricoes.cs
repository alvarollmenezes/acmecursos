namespace AcmeCursos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inscricoes : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Estudantes", newName: "Estudante");
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscricao", "EstudanteId", "dbo.Estudante");
            DropForeignKey("dbo.Inscricao", "CursoId", "dbo.Curso");
            DropIndex("dbo.Inscricao", new[] { "EstudanteId" });
            DropIndex("dbo.Inscricao", new[] { "CursoId" });
            DropTable("dbo.Inscricao");
            RenameTable(name: "dbo.Estudante", newName: "Estudantes");
        }
    }
}
