namespace ProdutosMarcas.Persistencia.EF.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ProdutosMarcasDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.ProdutosMarcasDbContext context)
        {
            
        }
    }
}
