namespace RestauranteWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pratos",
                c => new
                    {
                        NomePrato = c.String(nullable: false, maxLength: 128),
                        NomeRestauranteID = c.String(nullable: false, maxLength: 128),
                        PrecoPrato = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.NomePrato)
                .ForeignKey("dbo.Restaurantes", t => t.NomeRestauranteID, cascadeDelete: true)
                .Index(t => t.NomeRestauranteID);
            
            CreateTable(
                "dbo.Restaurantes",
                c => new
                    {
                        NomeRestauranteID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.NomeRestauranteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pratos", "NomeRestauranteID", "dbo.Restaurantes");
            DropIndex("dbo.Pratos", new[] { "NomeRestauranteID" });
            DropTable("dbo.Restaurantes");
            DropTable("dbo.Pratos");
        }
    }
}
