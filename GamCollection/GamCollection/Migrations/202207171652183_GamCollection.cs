namespace GamCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamCollection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dataziones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mostras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        Technique = c.String(),
                        Dimension = c.String(),
                        Image = c.String(),
                        Autore_Id = c.Int(),
                        Datazione_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autores", t => t.Autore_Id)
                .ForeignKey("dbo.Dataziones", t => t.Datazione_Id)
                .Index(t => t.Autore_Id)
                .Index(t => t.Datazione_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mostras", "Datazione_Id", "dbo.Dataziones");
            DropForeignKey("dbo.Mostras", "Autore_Id", "dbo.Autores");
            DropIndex("dbo.Mostras", new[] { "Datazione_Id" });
            DropIndex("dbo.Mostras", new[] { "Autore_Id" });
            DropTable("dbo.Mostras");
            DropTable("dbo.Dataziones");
            DropTable("dbo.Autores");
        }
    }
}
