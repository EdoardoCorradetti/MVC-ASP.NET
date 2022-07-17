namespace GamCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamCollection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Datazioni",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mostre",
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
                .ForeignKey("dbo.Autori", t => t.Autore_Id)
                .ForeignKey("dbo.Datazioni", t => t.Datazione_Id)
                .Index(t => t.Autore_Id)
                .Index(t => t.Datazione_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mostre", "Datazione_Id", "dbo.Datazioni");
            DropForeignKey("dbo.Mostre", "Autore_Id", "dbo.Autori");
            DropIndex("dbo.Mostre", new[] { "Datazione_Id" });
            DropIndex("dbo.Mostre", new[] { "Autore_Id" });
            DropTable("dbo.Mostre");
            DropTable("dbo.Datazioni");
            DropTable("dbo.Autori");
        }
    }
}
