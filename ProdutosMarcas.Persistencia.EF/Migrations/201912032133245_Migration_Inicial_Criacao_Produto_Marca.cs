namespace ProdutosMarcas.Persistencia.EF.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Migration_Inicial_Criacao_Produto_Marca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        MarcarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcarId)
                .Index(t => t.MarcarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "MarcarId", "dbo.Marcas");
            DropIndex("dbo.Produtoes", new[] { "MarcarId" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Marcas");
        }
    }
}
