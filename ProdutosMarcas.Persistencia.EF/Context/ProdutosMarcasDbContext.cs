/*
 * Arquivo: classe ProdutosMarcasDbContext
 * Autor: Paulo Alves
 * Descrição: responsável pela persistência com o banco de dados criando tabelas e relacionamento entre essas mesmas tabelas
 * Data: 03/12/2019
*/

using ProdutosMarcas.Dominio.Entities;
using System.Data.Entity;

namespace ProdutosMarcas.Persistencia.EF.Context
{
    public class ProdutosMarcasDbContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Marca> Marca { get; set; }

        public ProdutosMarcasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasRequired(p => p.Marca)
                .WithMany(p => p.Produtos)
                .HasForeignKey(fk => fk.MarcarId)
                .WillCascadeOnDelete(false);
        }
    }
}
