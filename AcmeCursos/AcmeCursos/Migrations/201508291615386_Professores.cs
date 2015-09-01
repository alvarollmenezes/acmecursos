namespace AcmeCursos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Professores : DbMigration
    {
        public override void Up()
        {
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
            DropIndex("dbo.ProfessorCursoes", new[] { "Curso_Id" });
            DropIndex("dbo.ProfessorCursoes", new[] { "Professor_Id" });
            DropTable("dbo.ProfessorCursoes");
            DropTable("dbo.Professor");
        }
    }
}
