/*
 * Arquivo: class RepositorioProduto
 * Autor: Paulo Alves
 * Descrição: responsável por herdar métodos genéricos da interface IRepositorioGenerico para a entidade Produto
 * Data: 04/12/2019
*/

using ProdutosMarcas.Dominio.Entities;
using ProdutosMarcas.Persistencia.EF.Context;
using ProdutosMarcas.Repositorio.Comum.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosMarcas.Repositorio.EF.Repositories
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        public void Atualizar(Produto entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                Marca marca = contexto.Marca.Find(entidade.MarcarId);
                entidade.Marca = marca;
                contexto.Produto.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Produto entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Produto.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public void Inserir(Produto entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                Marca marca = contexto.Marca.Find(entidade.MarcarId);
                entidade.Marca = marca;
                contexto.Produto.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public Produto SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                return contexto.Produto.Include("Marca").Single(s => s.Id == id);
            }
        }

        public Task<List<Produto>> SelecionarTodos()
        {
            return Task.Run(() => 
            {
                using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
                {
                    return contexto.Produto.Include("Marca").ToList();
                }
            });
        }
    }
}
